namespace IPCamera
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.txtUrl1 = new System.Windows.Forms.TextBox();
            this.txtGroup1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.txtGroup2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mskDelay1 = new System.Windows.Forms.MaskedTextBox();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDelay2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.txtGroup1.SuspendLayout();
            this.txtGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(12, 12);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(357, 265);
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(428, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(357, 265);
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            // 
            // txtUrl1
            // 
            this.txtUrl1.Location = new System.Drawing.Point(6, 29);
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.Size = new System.Drawing.Size(253, 19);
            this.txtUrl1.TabIndex = 1;
            // 
            // txtGroup1
            // 
            this.txtGroup1.Controls.Add(this.label3);
            this.txtGroup1.Controls.Add(this.label2);
            this.txtGroup1.Controls.Add(this.label1);
            this.txtGroup1.Controls.Add(this.txtPass1);
            this.txtGroup1.Controls.Add(this.txtUser1);
            this.txtGroup1.Controls.Add(this.txtUrl1);
            this.txtGroup1.Location = new System.Drawing.Point(12, 293);
            this.txtGroup1.Name = "txtGroup1";
            this.txtGroup1.Size = new System.Drawing.Size(276, 145);
            this.txtGroup1.TabIndex = 2;
            this.txtGroup1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(6, 119);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(253, 19);
            this.txtPass1.TabIndex = 1;
            // 
            // txtUser1
            // 
            this.txtUser1.Location = new System.Drawing.Point(6, 74);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(253, 19);
            this.txtUser1.TabIndex = 1;
            // 
            // txtGroup2
            // 
            this.txtGroup2.Controls.Add(this.label4);
            this.txtGroup2.Controls.Add(this.label5);
            this.txtGroup2.Controls.Add(this.label6);
            this.txtGroup2.Controls.Add(this.txtPass2);
            this.txtGroup2.Controls.Add(this.txtUser2);
            this.txtGroup2.Controls.Add(this.txtUrl2);
            this.txtGroup2.Location = new System.Drawing.Point(428, 293);
            this.txtGroup2.Name = "txtGroup2";
            this.txtGroup2.Size = new System.Drawing.Size(276, 145);
            this.txtGroup2.TabIndex = 2;
            this.txtGroup2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "PASS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "USER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "URL";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(6, 119);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(253, 19);
            this.txtPass2.TabIndex = 1;
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(6, 74);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(253, 19);
            this.txtUser2.TabIndex = 1;
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(6, 29);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(253, 19);
            this.txtUrl2.TabIndex = 1;
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(294, 315);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(75, 33);
            this.btnStart1.TabIndex = 3;
            this.btnStart1.Text = "開始";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.BtnStart1_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(294, 359);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(75, 34);
            this.btnStop1.TabIndex = 3;
            this.btnStop1.Text = "停止";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.BtnStop1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "周期設定";
            // 
            // mskDelay1
            // 
            this.mskDelay1.Location = new System.Drawing.Point(296, 411);
            this.mskDelay1.Mask = "99999";
            this.mskDelay1.Name = "mskDelay1";
            this.mskDelay1.Size = new System.Drawing.Size(73, 19);
            this.mskDelay1.TabIndex = 5;
            this.mskDelay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskDelay1.ValidatingType = typeof(int);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(710, 315);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 33);
            this.btnStart2.TabIndex = 3;
            this.btnStart2.Text = "開始";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.BtnStart2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(710, 359);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(75, 34);
            this.btnStop2.TabIndex = 3;
            this.btnStop2.Text = "停止";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.BtnStop2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "周期設定";
            // 
            // mskDelay2
            // 
            this.mskDelay2.Location = new System.Drawing.Point(712, 411);
            this.mskDelay2.Mask = "99999";
            this.mskDelay2.Name = "mskDelay2";
            this.mskDelay2.Size = new System.Drawing.Size(73, 19);
            this.mskDelay2.TabIndex = 5;
            this.mskDelay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskDelay2.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskDelay2);
            this.Controls.Add(this.mskDelay1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.txtGroup2);
            this.Controls.Add(this.txtGroup1);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.txtGroup1.ResumeLayout(false);
            this.txtGroup1.PerformLayout();
            this.txtGroup2.ResumeLayout(false);
            this.txtGroup2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.TextBox txtUrl1;
        private System.Windows.Forms.GroupBox txtGroup1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.GroupBox txtGroup2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskDelay1;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskDelay2;
    }
}

