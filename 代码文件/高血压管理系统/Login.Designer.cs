namespace 高血压管理系统
{
    partial class Login
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
            this.lab_账号 = new System.Windows.Forms.Label();
            this.lab_密码 = new System.Windows.Forms.Label();
            this.txb_Number = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_账号
            // 
            this.lab_账号.AutoSize = true;
            this.lab_账号.Location = new System.Drawing.Point(64, 102);
            this.lab_账号.Name = "lab_账号";
            this.lab_账号.Size = new System.Drawing.Size(52, 15);
            this.lab_账号.TabIndex = 0;
            this.lab_账号.Text = "账号：";
            this.lab_账号.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_密码
            // 
            this.lab_密码.AutoSize = true;
            this.lab_密码.Location = new System.Drawing.Point(64, 161);
            this.lab_密码.Name = "lab_密码";
            this.lab_密码.Size = new System.Drawing.Size(52, 15);
            this.lab_密码.TabIndex = 1;
            this.lab_密码.Text = "密码：";
            this.lab_密码.Click += new System.EventHandler(this.lab_密码_Click);
            // 
            // txb_Number
            // 
            this.txb_Number.Location = new System.Drawing.Point(122, 92);
            this.txb_Number.Name = "txb_Number";
            this.txb_Number.Size = new System.Drawing.Size(100, 25);
            this.txb_Number.TabIndex = 2;
            this.txb_Number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(122, 151);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(100, 25);
            this.txb_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(122, 238);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 332);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Number);
            this.Controls.Add(this.lab_密码);
            this.Controls.Add(this.lab_账号);
            this.Name = "Login";
            this.Text = "高血压管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_账号;
        private System.Windows.Forms.Label lab_密码;
        private System.Windows.Forms.TextBox txb_Number;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}

