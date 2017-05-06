namespace Runner
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.labelLovePath = new System.Windows.Forms.Label();
			this.labelAppPath = new System.Windows.Forms.Label();
			this.textBoxLovePath = new System.Windows.Forms.TextBox();
			this.textBoxAppPath = new System.Windows.Forms.TextBox();
			this.buttonLovePath = new System.Windows.Forms.Button();
			this.buttonAppPath = new System.Windows.Forms.Button();
			this.buttonRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelLovePath
			// 
			this.labelLovePath.AutoSize = true;
			this.labelLovePath.Location = new System.Drawing.Point(10, 15);
			this.labelLovePath.Name = "labelLovePath";
			this.labelLovePath.Size = new System.Drawing.Size(56, 12);
			this.labelLovePath.TabIndex = 0;
			this.labelLovePath.Text = "Love Path";
			// 
			// labelAppPath
			// 
			this.labelAppPath.AutoSize = true;
			this.labelAppPath.Location = new System.Drawing.Point(10, 53);
			this.labelAppPath.Name = "labelAppPath";
			this.labelAppPath.Size = new System.Drawing.Size(52, 12);
			this.labelAppPath.TabIndex = 1;
			this.labelAppPath.Text = "App Path";
			// 
			// textBoxLovePath
			// 
			this.textBoxLovePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLovePath.Location = new System.Drawing.Point(75, 12);
			this.textBoxLovePath.Name = "textBoxLovePath";
			this.textBoxLovePath.Size = new System.Drawing.Size(598, 19);
			this.textBoxLovePath.TabIndex = 2;
			// 
			// textBoxAppPath
			// 
			this.textBoxAppPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAppPath.Location = new System.Drawing.Point(75, 50);
			this.textBoxAppPath.Name = "textBoxAppPath";
			this.textBoxAppPath.Size = new System.Drawing.Size(598, 19);
			this.textBoxAppPath.TabIndex = 3;
			// 
			// buttonLovePath
			// 
			this.buttonLovePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLovePath.Location = new System.Drawing.Point(679, 10);
			this.buttonLovePath.Name = "buttonLovePath";
			this.buttonLovePath.Size = new System.Drawing.Size(31, 23);
			this.buttonLovePath.TabIndex = 4;
			this.buttonLovePath.Text = "...";
			this.buttonLovePath.UseVisualStyleBackColor = true;
			this.buttonLovePath.Click += new System.EventHandler(this.buttonLovePath_Click);
			// 
			// buttonAppPath
			// 
			this.buttonAppPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAppPath.Location = new System.Drawing.Point(679, 48);
			this.buttonAppPath.Name = "buttonAppPath";
			this.buttonAppPath.Size = new System.Drawing.Size(31, 23);
			this.buttonAppPath.TabIndex = 5;
			this.buttonAppPath.Text = "...";
			this.buttonAppPath.UseVisualStyleBackColor = true;
			this.buttonAppPath.Click += new System.EventHandler(this.buttonAppPath_Click);
			// 
			// buttonRun
			// 
			this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRun.Location = new System.Drawing.Point(12, 88);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(697, 44);
			this.buttonRun.TabIndex = 6;
			this.buttonRun.Text = "Run";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 146);
			this.Controls.Add(this.buttonRun);
			this.Controls.Add(this.buttonAppPath);
			this.Controls.Add(this.buttonLovePath);
			this.Controls.Add(this.textBoxAppPath);
			this.Controls.Add(this.textBoxLovePath);
			this.Controls.Add(this.labelAppPath);
			this.Controls.Add(this.labelLovePath);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Love Runner";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLovePath;
        private System.Windows.Forms.Label labelAppPath;
        private System.Windows.Forms.TextBox textBoxLovePath;
        private System.Windows.Forms.TextBox textBoxAppPath;
        private System.Windows.Forms.Button buttonLovePath;
        private System.Windows.Forms.Button buttonAppPath;
        private System.Windows.Forms.Button buttonRun;
    }
}

