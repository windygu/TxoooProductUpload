﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using TxoooProductUpload.UI.CefGlue;
using Xilium.CefGlue;
using Xilium.CefGlue.WindowsForms;

namespace TxoooProductUpload.UI.CefGlue
{
    //CefBrowser: 该类代表一个浏览器对象，在 browser 进程中该类的方法可以被任意线程调用。在 render 进程中只能在主线程被调用。

    //CefFrame: 表示浏览器窗口中的一个 frame，在 browser 进程中该类的方法可以被任意线程调用（简单理解就是 Frame 标识一个页面，通过该类开发者可以加载某一URL 或者一段 HTML 代码，获取页面的源码和文本，URL，V8 执行上下文，访问页面中的 DOM）。

    //CefBrowserHost: 该类在浏览器窗口来看代表了 browser 进程，同时也暴露了与浏览器窗口相关的接口，该类的方法只能在 browser 进程中调用，但可以在 browser 进程的任意线程中被调用。
    //该类的主要方法如下：
    //【CreateBrowser】创建浏览器对象。需要传入的参数包括 CefWindowInfo 对象，CefClient 对象，默认的 URL， 以及浏览器启动时参数设置。
    //【CloseBrowser】请求关闭浏览器对象。该函数被调用是会触发 JS 'onbeforeunload' 事件，如果参数 force_close为 false，并且提供了 onbeforeunload 事件的回调函数，则提示用户是否关闭浏览器，此时用户可以选取取消操作。如果 force_close为 true，则直接关闭浏览器。
    //【GetBrowser】获取浏览器对象(在 CefBrowser 类中可以通过调用 GetHost() 获取与之对应的 CefBrowserHost)
    //【GetClient】获取 CefClient 对象
    //【GetOpenerWindowHandle】获取该浏览器对象的窗口句柄，如果是弹出窗口，则返回 NULL

    [ToolboxBitmap(typeof(CefWebBrowser))]
    class CefWebBrowser : Control
    {private bool _handleCreated;

        private CefBrowser _browser;
        private IntPtr _browserWindowHandle;

        public CefWebBrowser()
        {
            SetStyle(
                ControlStyles.ContainerControl
                | ControlStyles.ResizeRedraw
                | ControlStyles.FixedWidth
                | ControlStyles.FixedHeight
                | ControlStyles.StandardClick
                | ControlStyles.UserMouse
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.StandardDoubleClick
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.CacheText
                | ControlStyles.EnableNotifyMessage
                | ControlStyles.DoubleBuffer
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.UseTextForAccessibility
                | ControlStyles.Opaque,
                false);

            SetStyle(
                ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.Selectable,
                true);

            StartUrl = "about:blank";
        }


        [DefaultValue("http://iwenli.org")]
        public string StartUrl { get; set; }

        [Browsable(false)]
        public CefBrowserSettings BrowserSettings { get; set; }

        internal void InvokeIfRequired(Action a)
        {
            if (InvokeRequired)
                Invoke(a);
            else
                a();
        }

        protected virtual WebCefClient CreateWebClient()
        {
            return new WebCefClient(this);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (DesignMode)
            {
                if (!_handleCreated) Paint += PaintInDesignMode;
            }
            else
            {
                //CefWindowInfo是CEF浏览器窗口实现的类，其中包含了在windows、linux、MAC下的具体实现
                //此类中的Create静态方法负责创建这个类的实例，我在windows下执行这一句，将得到windows下CEF浏览器的实现方式
                var windowInfo = CefWindowInfo.Create();

                //此行代码负责把创建的CEF浏览器窗口与我们创建的winform窗口结合起来
                //this.Handle就是我们创建的winform窗口的句柄
                //SetAsChild函数使CEF浏览器窗口作为winform窗口的子窗口呈现
                //CefRectangle标志着CEF浏览器窗口将出现在父窗口中的位置和大小
                windowInfo.SetAsChild(Handle, new CefRectangle { X = 0, Y = 0, Width = Width, Height = Height });
                

                //这个类没有任何逻辑和属性，只是继承了CefClient类
                //CefClient类有很多虚方法以供重写，比如GetDisplayHandler、GetDownloadHandler、GetJSDialogHandler等等
                //注意：此类很重要，我们将在接下来的章节中为这个类添加很多内容
                var client = CreateWebClient();

                //之前我们在Program中设置的是CefSettings,那是针对CEF环境的一些全局设置
                //这里是CefBrowserSettings,这是针对CEF浏览器环境的一些全局设置,可以在这里配置的参数有很多
                //比如：DefaultEncoding（用于所有网页内容的编码方式，默认为ISO-8859-1）
                //UserStyleSheetLocation（用于所有网页的样式，应该按照这样的格式设置这个字段：data:text/css;charset=utf-8;base64,[csscontent]）
                //RemoteFonts（用于所有网页的字体）
                //JavaScript（用于所有网页是否可以执行JS脚本）
                //JavaScriptOpenWindows（用于所有网页是否可以通过JS来打开窗口）
                //（还有很多类似的设置，读者可以自己去研究）
                var settings = BrowserSettings;
                if (settings == null) settings = new CefBrowserSettings {
                    JavaScriptOpenWindows = CefState.Disabled
                };

                //最后一个参数就是你想让浏览器访问的页面
                //注意：这个方法是异步执行的（非阻塞的），也就是说你无法知道什么时候窗口被创建出来
                CefBrowserHost.CreateBrowser(windowInfo, client, settings, StartUrl);

            }

            _handleCreated = true;
        }

        protected override void Dispose(bool disposing)
        {
            // TODO: ugly hack to avoid crashes when CefWebBrowser are Finalized and underlying objects already finalized
            if (_browser != null && disposing) 
            {
                var host = _browser.GetHost();
                if (host != null)
                {
                    host.CloseBrowser();
                    host.Dispose();
                }
                _browser.Dispose();
                _browser = null;
                _browserWindowHandle = IntPtr.Zero;
            }

            base.Dispose(disposing);
        }

        public event EventHandler BrowserCreated;

        internal protected virtual void OnBrowserAfterCreated(CefBrowser browser)
        {
            _browser = browser;
            _browserWindowHandle = _browser.GetHost().GetWindowHandle();
            ResizeWindow(_browserWindowHandle, Width, Height);

            if (BrowserCreated != null)
                BrowserCreated(this, EventArgs.Empty);
        }

        internal protected virtual void OnTitleChanged(TitleChangedEventArgs e)
        {
            Title = e.Title;

            var handler = TitleChanged;
            if (handler != null) handler(this, e);
        }

        public string Title { get; private set; }

        public event EventHandler<TitleChangedEventArgs> TitleChanged;

        internal protected virtual void OnAddressChanged(AddressChangedEventArgs e)
        {
            Address = e.Address;

            var handler = AddressChanged;
            if (handler != null) handler(this, e);
        }

        public string Address { get; private set; }

        public event EventHandler<AddressChangedEventArgs> AddressChanged;

        internal protected virtual void OnStatusMessage(StatusMessageEventArgs e)
        {
            var handler = StatusMessage;
            if (handler != null) handler(this, e);
        }

        public event EventHandler<StatusMessageEventArgs> StatusMessage;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (_browserWindowHandle != IntPtr.Zero)
            {
                // Ignore size changes when form are minimized.
                var form = TopLevelControl as Form;
                if (form != null && form.WindowState == FormWindowState.Minimized)
                {
                    return;
                }

                ResizeWindow(_browserWindowHandle, Width, Height);
            }
        }

        private void PaintInDesignMode(object sender, PaintEventArgs e)
        {
            var width = this.Width;
            var height = this.Height;
            if (width > 1 && height > 1)
            {
                var brush = new SolidBrush(this.ForeColor);
                var pen = new Pen(this.ForeColor);
                pen.DashStyle = DashStyle.Dash;

                e.Graphics.DrawRectangle(pen, 0, 0, width - 1, height - 1);

                var fontHeight = (int)(this.Font.GetHeight(e.Graphics) * 1.25);

                var x = 3;
                var y = 3;

                e.Graphics.DrawString("CefWebBrowser", Font, brush, x, y + (0 * fontHeight));
                e.Graphics.DrawString(string.Format("StartUrl: {0}", StartUrl), Font, brush, x, y + (1 * fontHeight));

                brush.Dispose();
                pen.Dispose();
            }
        }

        public void InvalidateSize()
        {
            ResizeWindow(_browserWindowHandle, Width, Height);
        }

        private static void ResizeWindow(IntPtr handle, int width, int height)
        {
            if (handle != IntPtr.Zero)
            {
                NativeMethods.SetWindowPos(handle, IntPtr.Zero,
                    0, 0, width, height,
                    SetWindowPosFlags.NoMove | SetWindowPosFlags.NoZOrder
                    );
            }
        }

        public CefBrowser Browser { get { return _browser; } }

        public event EventHandler<ConsoleMessageEventArgs> ConsoleMessage;

        internal protected virtual void OnConsoleMessage(ConsoleMessageEventArgs e)
        {
            if (ConsoleMessage != null)
                ConsoleMessage(this, e);
            else
                e.Handled = false;
        }

        public event EventHandler<LoadingStateChangeEventArgs> LoadingStateChange;

        internal protected virtual void OnLoadingStateChange(LoadingStateChangeEventArgs e)
        {
            if (LoadingStateChange != null)
                LoadingStateChange(this, e);
        }

        public event EventHandler<TooltipEventArgs> Tooltip;

        internal protected virtual void OnTooltip(TooltipEventArgs e)
        {
            if (Tooltip != null)
                Tooltip(this, e);
            else
                e.Handled = false;
        }

        public event EventHandler BeforeClose;

        internal protected virtual void OnBeforeClose()
        {
            _browserWindowHandle = IntPtr.Zero;
            if (BeforeClose != null)
                BeforeClose(this, EventArgs.Empty);
        }

        public event EventHandler<BeforePopupEventArgs> BeforePopup;

        internal protected virtual void OnBeforePopup(BeforePopupEventArgs e)
        {
            if (BeforePopup != null)
                BeforePopup(this, e);
            else
                e.Handled = false;
        }

        public event EventHandler<LoadEndEventArgs> LoadEnd;

        internal protected virtual void OnLoadEnd(LoadEndEventArgs e)
        {
            if (LoadEnd != null)
                LoadEnd(this, e);
        }

        public event EventHandler<LoadErrorEventArgs> LoadError;

        internal protected virtual void OnLoadError(LoadErrorEventArgs e)
        {
            if (LoadError != null)
                LoadError(this, e);
        }

        public event EventHandler<LoadStartEventArgs> LoadStarted;

        internal protected virtual void OnLoadStart(LoadStartEventArgs e)
        {
            if (LoadStarted != null)
                LoadStarted(this, e);
        }

        public event EventHandler<PluginCrashedEventArgs> PluginCrashed;

        internal protected virtual void OnPluginCrashed(PluginCrashedEventArgs e)
        {
            if (PluginCrashed != null)
                PluginCrashed(this, e);
        }

        public event EventHandler<RenderProcessTerminatedEventArgs> RenderProcessTerminated;

        internal protected virtual void OnRenderProcessTerminated(RenderProcessTerminatedEventArgs e)
        {
            if (RenderProcessTerminated != null)
                RenderProcessTerminated(this, e);
        }
    }
}
