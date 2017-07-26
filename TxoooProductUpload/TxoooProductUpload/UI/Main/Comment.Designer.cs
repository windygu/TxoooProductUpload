﻿namespace TxoooProductUpload.UI.Main
{
    partial class Comment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetProductInfo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.batchPage = new System.Windows.Forms.TabPage();
            this.gbPage1 = new System.Windows.Forms.GroupBox();
            this.txtJson = new System.Windows.Forms.RichTextBox();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnAddComments = new System.Windows.Forms.Button();
            this.btnTmall = new System.Windows.Forms.Button();
            this.tcReviews = new System.Windows.Forms.TabControl();
            this.oneBatch = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAddReviewImage = new System.Windows.Forms.PictureBox();
            this.txtReviewContent = new System.Windows.Forms.RichTextBox();
            this.txtMchReplyContent = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateHeadPic = new System.Windows.Forms.Button();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.txtUpdateHeadPicUrl = new System.Windows.Forms.TextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProperty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.batchPage.SuspendLayout();
            this.gbPage1.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.tcReviews.SuspendLayout();
            this.oneBatch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddReviewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetProductInfo);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "验证商品信息";
            // 
            // btnGetProductInfo
            // 
            this.btnGetProductInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGetProductInfo.Location = new System.Drawing.Point(789, 19);
            this.btnGetProductInfo.Name = "btnGetProductInfo";
            this.btnGetProductInfo.Size = new System.Drawing.Size(123, 32);
            this.btnGetProductInfo.TabIndex = 3;
            this.btnGetProductInfo.Text = "解析商品信息(&L)";
            this.btnGetProductInfo.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.Location = new System.Drawing.Point(3, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(780, 32);
            this.txtUrl.TabIndex = 2;
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.Gray;
            this.txtLog.Location = new System.Drawing.Point(0, 306);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(915, 231);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // batchPage
            // 
            this.batchPage.Controls.Add(this.gbPage1);
            this.batchPage.Controls.Add(this.gbAction);
            this.batchPage.Location = new System.Drawing.Point(4, 26);
            this.batchPage.Name = "batchPage";
            this.batchPage.Padding = new System.Windows.Forms.Padding(3);
            this.batchPage.Size = new System.Drawing.Size(907, 222);
            this.batchPage.TabIndex = 0;
            this.batchPage.Text = "批量抓取评价";
            this.batchPage.UseVisualStyleBackColor = true;
            // 
            // gbPage1
            // 
            this.gbPage1.Controls.Add(this.txtJson);
            this.gbPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPage1.Location = new System.Drawing.Point(3, 60);
            this.gbPage1.Name = "gbPage1";
            this.gbPage1.Size = new System.Drawing.Size(901, 159);
            this.gbPage1.TabIndex = 5;
            this.gbPage1.TabStop = false;
            this.gbPage1.Text = "这里输入商品评价JSON";
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Location = new System.Drawing.Point(3, 19);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(895, 137);
            this.txtJson.TabIndex = 0;
            this.txtJson.Text = "";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.btnAddComments);
            this.gbAction.Controls.Add(this.btnTmall);
            this.gbAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAction.Location = new System.Drawing.Point(3, 3);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(901, 57);
            this.gbAction.TabIndex = 4;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "操作";
            // 
            // btnAddComments
            // 
            this.btnAddComments.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddComments.Location = new System.Drawing.Point(637, 19);
            this.btnAddComments.Name = "btnAddComments";
            this.btnAddComments.Size = new System.Drawing.Size(123, 35);
            this.btnAddComments.TabIndex = 3;
            this.btnAddComments.Text = "批量添加评价(&A)";
            this.btnAddComments.UseVisualStyleBackColor = true;
            // 
            // btnTmall
            // 
            this.btnTmall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTmall.Location = new System.Drawing.Point(760, 19);
            this.btnTmall.Name = "btnTmall";
            this.btnTmall.Size = new System.Drawing.Size(138, 35);
            this.btnTmall.TabIndex = 2;
            this.btnTmall.Text = "复制天猫抓取脚本(&T)";
            this.btnTmall.UseVisualStyleBackColor = true;
            // 
            // tcReviews
            // 
            this.tcReviews.Controls.Add(this.oneBatch);
            this.tcReviews.Controls.Add(this.batchPage);
            this.tcReviews.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcReviews.Location = new System.Drawing.Point(0, 0);
            this.tcReviews.Name = "tcReviews";
            this.tcReviews.SelectedIndex = 0;
            this.tcReviews.Size = new System.Drawing.Size(915, 252);
            this.tcReviews.TabIndex = 0;
            // 
            // oneBatch
            // 
            this.oneBatch.Controls.Add(this.groupBox2);
            this.oneBatch.Location = new System.Drawing.Point(4, 26);
            this.oneBatch.Name = "oneBatch";
            this.oneBatch.Padding = new System.Windows.Forms.Padding(3);
            this.oneBatch.Size = new System.Drawing.Size(907, 222);
            this.oneBatch.TabIndex = 2;
            this.oneBatch.Text = "添加单条评价";
            this.oneBatch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtReviewContent);
            this.groupBox2.Controls.Add(this.txtMchReplyContent);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnUpdateHeadPic);
            this.groupBox2.Controls.Add(this.pbHead);
            this.groupBox2.Controls.Add(this.txtUpdateHeadPicUrl);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNickName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbProperty);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 216);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.pbAddReviewImage);
            this.groupBox3.Location = new System.Drawing.Point(218, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 70);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "评价图片";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(45, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 48);
            this.panel1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.panel1, "最多添加6张评论图片，点击 图片删除重传");
            // 
            // pbAddReviewImage
            // 
            this.pbAddReviewImage.Image = global::TxoooProductUpload.Properties.Resources.add1;
            this.pbAddReviewImage.Location = new System.Drawing.Point(9, 27);
            this.pbAddReviewImage.Name = "pbAddReviewImage";
            this.pbAddReviewImage.Size = new System.Drawing.Size(30, 30);
            this.pbAddReviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddReviewImage.TabIndex = 11;
            this.pbAddReviewImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAddReviewImage, "点击上传评价图片");
            // 
            // txtReviewContent
            // 
            this.txtReviewContent.BackColor = System.Drawing.Color.White;
            this.txtReviewContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReviewContent.Location = new System.Drawing.Point(285, 55);
            this.txtReviewContent.Name = "txtReviewContent";
            this.txtReviewContent.Size = new System.Drawing.Size(304, 57);
            this.txtReviewContent.TabIndex = 9;
            this.txtReviewContent.Text = "";
            // 
            // txtMchReplyContent
            // 
            this.txtMchReplyContent.Location = new System.Drawing.Point(285, 25);
            this.txtMchReplyContent.Name = "txtMchReplyContent";
            this.txtMchReplyContent.Size = new System.Drawing.Size(304, 23);
            this.txtMchReplyContent.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 23);
            this.dateTimePicker1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "评价展示时候的评价时间");
            // 
            // btnUpdateHeadPic
            // 
            this.btnUpdateHeadPic.Location = new System.Drawing.Point(762, 55);
            this.btnUpdateHeadPic.Name = "btnUpdateHeadPic";
            this.btnUpdateHeadPic.Size = new System.Drawing.Size(137, 23);
            this.btnUpdateHeadPic.TabIndex = 6;
            this.btnUpdateHeadPic.Text = "从网址更新头像(&U)";
            this.btnUpdateHeadPic.UseVisualStyleBackColor = true;
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(682, 20);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(70, 70);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHead.TabIndex = 5;
            this.pbHead.TabStop = false;
            this.toolTip1.SetToolTip(this.pbHead, "点击头像上传更换");
            // 
            // txtUpdateHeadPicUrl
            // 
            this.txtUpdateHeadPicUrl.Location = new System.Drawing.Point(761, 19);
            this.txtUpdateHeadPicUrl.Name = "txtUpdateHeadPicUrl";
            this.txtUpdateHeadPicUrl.Size = new System.Drawing.Size(137, 23);
            this.txtUpdateHeadPicUrl.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(76, 152);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(121, 23);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(76, 121);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(121, 23);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 89);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "评价时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "快递打分：";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(76, 58);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(121, 23);
            this.txtNickName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNickName, "评价人的昵称");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "商品打分：";
            // 
            // cbProperty
            // 
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.Location = new System.Drawing.Point(76, 24);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.Size = new System.Drawing.Size(121, 25);
            this.cbProperty.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "点 赞  数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "昵      称：";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(612, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 49);
            this.label7.TabIndex = 0;
            this.label7.Text = "1、点击头像可上传图片更换头像\r\n2、如需上传网络图片，只需把网址放到下面文本框替换即可";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "商家回复：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "头      像：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "商家回复：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "评价属性：";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TIM截图20170726134735.png");
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tcReviews);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加评价";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.batchPage.ResumeLayout(false);
            this.gbPage1.ResumeLayout(false);
            this.gbAction.ResumeLayout(false);
            this.tcReviews.ResumeLayout(false);
            this.oneBatch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddReviewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetProductInfo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TabPage batchPage;
        private System.Windows.Forms.GroupBox gbPage1;
        private System.Windows.Forms.RichTextBox txtJson;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Button btnAddComments;
        private System.Windows.Forms.Button btnTmall;
        private System.Windows.Forms.TabControl tcReviews;
        private System.Windows.Forms.TabPage oneBatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateHeadPicUrl;
        private System.Windows.Forms.Button btnUpdateHeadPic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMchReplyContent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtReviewContent;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbAddReviewImage;
        private System.Windows.Forms.Panel panel1;
    }
}