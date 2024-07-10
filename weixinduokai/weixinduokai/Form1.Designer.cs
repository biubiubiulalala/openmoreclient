namespace weixinduokai
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WeChatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.selectPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeChatButton
            // 
            this.WeChatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WeChatButton.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WeChatButton.Location = new System.Drawing.Point(45, 265);
            this.WeChatButton.Name = "WeChatButton";
            this.WeChatButton.Size = new System.Drawing.Size(500, 50);
            this.WeChatButton.TabIndex = 0;
            this.WeChatButton.Text = "一键多开";
            this.WeChatButton.UseVisualStyleBackColor = false;
            this.WeChatButton.Click += new System.EventHandler(this.WeChatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "需要多开的客户端数量：";
            // 
            // clientTextBox
            // 
            this.clientTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.clientTextBox.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clientTextBox.Location = new System.Drawing.Point(399, 187);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(146, 35);
            this.clientTextBox.TabIndex = 1;
            this.clientTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientTextBox_KeyPress);
            // 
            // selectPath
            // 
            this.selectPath.BackColor = System.Drawing.Color.Yellow;
            this.selectPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectPath.Location = new System.Drawing.Point(45, 97);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(500, 33);
            this.selectPath.TabIndex = 3;
            this.selectPath.UseVisualStyleBackColor = false;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "如果需要手动选择路径请点击下面按钮（支有自动获取失败才需要手动）：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.WeChatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "桌面程序多开助手2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WeChatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.Label label2;
    }
}

