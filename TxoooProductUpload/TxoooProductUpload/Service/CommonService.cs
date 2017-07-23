﻿using FSLib.Network.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxoooProductUpload.Common;
using TxoooProductUpload.Service.Entities.Web;

namespace TxoooProductUpload.Service
{
    class CommonService : ServiceBase
    {
        const string _sqlFormatInsertIMg = @"INSERT INTO iwenli_image(SourceUrl,ToooUrl,UserId,Remard) values('{0}','{1}',{2},'{3}')";

        public CommonService(ServiceContext context) : base(context)
        {
        }

        /// <summary>
        /// 上传图片,成功返回url,失败返回空字符串
        /// </summary>
        /// <param name="url">网络图片URL</param>
        /// <returns></returns>
        public async Task<string> UploadImg(string url)
        {
            var stCtx = ServiceContext.Session.NetClient
               .Create<byte[]>(HttpMethod.Get, url);

            await stCtx.SendAsync();
            if (!stCtx.IsValid())
            {
                new Exception("CommonService.DowloadImage未能提交请求");
            }
            var imgUrl = await UploadImg(stCtx.Result);
            try
            {
                DbHelperOleDb.ExecuteSql(string.Format(_sqlFormatInsertIMg, url, imgUrl, ServiceContext.Session.Token.userid, string.Empty));
            }
            catch (Exception ex)
            {
                new Exception("CommonService.DowloadImage.DbHelperOleDb异常" + ex.Message);
            }
            return imgUrl;
        }

        /// <summary>
        /// 上传图片,成功返回url,失败返回空字符串
        /// </summary>
        /// <param name="image">Image对象的图片</param>
        /// <returns></returns>
        public async Task<string> UploadImg(Image image)
        {
            MemoryStream ms1 = new MemoryStream();
            image.Save(ms1, System.Drawing.Imaging.ImageFormat.Bmp);
            return await UploadImg(ms1.GetBuffer());
        }

        /// <summary>
        /// 上传图片,成功返回url,失败返回空字符串
        /// </summary>
        /// <param name="imageData">Image的字节流</param>
        /// <returns></returns>
        public async Task<string> UploadImg(byte[] imageData)
        {
            var data = new
            {
                file = new HttpVirtualBytePostFile(Guid.NewGuid().ToString("N") + ".jpg", imageData)
            };

            var stCtx = ServiceContext.Session.NetClient
                .Create<WebResponseResult<string>>(HttpMethod.Post, ApiList.UpdateImgFile, data: data);

            await stCtx.SendAsync();
            if (!stCtx.IsValid())
            {
                new Exception("CommonService.UploadImg未能提交请求");
            }

            if (stCtx.Result.success)
            {
                return stCtx.Result.msg;
            }
            return string.Empty;
        }
    }
}
