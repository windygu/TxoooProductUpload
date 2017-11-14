﻿namespace TxoooProductUpload.UI.Forms
{
    partial class SetSearchKeyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnSet = new CCWin.SkinControl.SkinButton();
            this.txtOriginalWord = new CCWin.SkinControl.SkinTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.txtOriginalWord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 203);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(123, 162);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSet.DownBack = null;
            this.btnSet.Location = new System.Drawing.Point(204, 162);
            this.btnSet.MouseBack = null;
            this.btnSet.Name = "btnSet";
            this.btnSet.NormlBack = null;
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "确定(&O)";
            this.btnSet.UseVisualStyleBackColor = false;
            // 
            // txtOriginalWord
            // 
            this.txtOriginalWord.BackColor = System.Drawing.Color.White;
            this.txtOriginalWord.DownBack = null;
            this.txtOriginalWord.Icon = null;
            this.txtOriginalWord.IconIsButton = false;
            this.txtOriginalWord.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtOriginalWord.IsPasswordChat = '\0';
            this.txtOriginalWord.IsSystemPasswordChar = false;
            this.txtOriginalWord.Lines = new string[0];
            this.txtOriginalWord.Location = new System.Drawing.Point(22, 40);
            this.txtOriginalWord.Margin = new System.Windows.Forms.Padding(0);
            this.txtOriginalWord.MaxLength = 32767;
            this.txtOriginalWord.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtOriginalWord.MouseBack = null;
            this.txtOriginalWord.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtOriginalWord.Multiline = true;
            this.txtOriginalWord.Name = "txtOriginalWord";
            this.txtOriginalWord.NormlBack = null;
            this.txtOriginalWord.Padding = new System.Windows.Forms.Padding(5);
            this.txtOriginalWord.ReadOnly = false;
            this.txtOriginalWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOriginalWord.Size = new System.Drawing.Size(255, 101);
            // 
            // 
            // 
            this.txtOriginalWord.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOriginalWord.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginalWord.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtOriginalWord.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtOriginalWord.SkinTxt.Multiline = true;
            this.txtOriginalWord.SkinTxt.Name = "BaseText";
            this.txtOriginalWord.SkinTxt.Size = new System.Drawing.Size(245, 91);
            this.txtOriginalWord.SkinTxt.TabIndex = 0;
            this.txtOriginalWord.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtOriginalWord.SkinTxt.WaterText = "搜索词";
            this.txtOriginalWord.TabIndex = 1;
            this.txtOriginalWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOriginalWord.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtOriginalWord.WaterText = "搜索词";
            this.txtOriginalWord.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "批量设置的搜索词(空格分开)：";
            // 
            // SetSearchKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 235);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetSearchKeyForm";
            this.Text = "设置搜索词";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinTextBox txtOriginalWord;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton btnSet;
        private CCWin.SkinControl.SkinButton btnCancel;
    }
}