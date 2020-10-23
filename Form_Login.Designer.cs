using System.ComponentModel;

namespace WindowsFormsApp4
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LoginBox1 = new System.Windows.Forms.TextBox();
            this.LoginBox2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Loginlabel1 = new System.Windows.Forms.Label();
            this.Loginlabel2 = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBox1
            // 
            this.LoginBox1.Location = new System.Drawing.Point(354, 146);
            this.LoginBox1.Name = "LoginBox1";
            this.LoginBox1.Size = new System.Drawing.Size(121, 25);
            this.LoginBox1.TabIndex = 0;
            this.LoginBox1.TextChanged += new System.EventHandler(this.LoginBox1_TextChanged);
            // 
            // LoginBox2
            // 
            this.LoginBox2.Location = new System.Drawing.Point(354, 207);
            this.LoginBox2.Name = "LoginBox2";
            this.LoginBox2.Size = new System.Drawing.Size(121, 25);
            this.LoginBox2.TabIndex = 1;
            this.LoginBox2.TextChanged += new System.EventHandler(this.LoginBox2_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(372, 262);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(70, 31);
            this.Login.TabIndex = 2;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Loginlabel1
            // 
            this.Loginlabel1.Location = new System.Drawing.Point(297, 149);
            this.Loginlabel1.Name = "Loginlabel1";
            this.Loginlabel1.Size = new System.Drawing.Size(51, 23);
            this.Loginlabel1.TabIndex = 3;
            this.Loginlabel1.Text = "账号:";
            this.Loginlabel1.Click += new System.EventHandler(this.Loginlabel1_Click);
            // 
            // Loginlabel2
            // 
            this.Loginlabel2.Location = new System.Drawing.Point(300, 208);
            this.Loginlabel2.Name = "Loginlabel2";
            this.Loginlabel2.Size = new System.Drawing.Size(48, 24);
            this.Loginlabel2.TabIndex = 4;
            this.Loginlabel2.Text = "密码:";
            this.Loginlabel2.Click += new System.EventHandler(this.Loginlabel2_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.LoginLabel.Location = new System.Drawing.Point(356, 88);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(86, 38);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "登录";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.Loginlabel2);
            this.Controls.Add(this.Loginlabel1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginBox2);
            this.Controls.Add(this.LoginBox1);
            this.Name = "Form_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LoginLabel;

        private System.Windows.Forms.Label Loginlabel2;

        private System.Windows.Forms.Label Loginlabel1;

        private System.Windows.Forms.Button Login;

        private System.Windows.Forms.TextBox LoginBox2;

        private System.Windows.Forms.TextBox LoginBox1;

        #endregion
    }
}