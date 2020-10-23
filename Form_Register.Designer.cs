using System.ComponentModel;

namespace WindowsFormsApp4
{
    partial class Form_Register
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
            this.RegisterBox1 = new System.Windows.Forms.TextBox();
            this.RegisterBox2 = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.Relabel1 = new System.Windows.Forms.Label();
            this.Relabel2 = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterBox1
            // 
            this.RegisterBox1.Location = new System.Drawing.Point(293, 109);
            this.RegisterBox1.Name = "RegisterBox1";
            this.RegisterBox1.Size = new System.Drawing.Size(147, 25);
            this.RegisterBox1.TabIndex = 0;
            this.RegisterBox1.TextChanged += new System.EventHandler(this.RegisterBox1_TextChanged);
            // 
            // RegisterBox2
            // 
            this.RegisterBox2.Location = new System.Drawing.Point(292, 181);
            this.RegisterBox2.Name = "RegisterBox2";
            this.RegisterBox2.Size = new System.Drawing.Size(147, 25);
            this.RegisterBox2.TabIndex = 1;
            this.RegisterBox2.TextChanged += new System.EventHandler(this.RegisterBox2_TextChanged);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(317, 242);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(94, 31);
            this.Register.TabIndex = 2;
            this.Register.Text = "注册";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Relabel1
            // 
            this.Relabel1.Location = new System.Drawing.Point(238, 109);
            this.Relabel1.Name = "Relabel1";
            this.Relabel1.Size = new System.Drawing.Size(53, 24);
            this.Relabel1.TabIndex = 3;
            this.Relabel1.Text = "账号:";
            this.Relabel1.Click += new System.EventHandler(this.Relabel1_Click);
            // 
            // Relabel2
            // 
            this.Relabel2.Location = new System.Drawing.Point(242, 184);
            this.Relabel2.Name = "Relabel2";
            this.Relabel2.Size = new System.Drawing.Size(49, 23);
            this.Relabel2.TabIndex = 4;
            this.Relabel2.Text = "密码:";
            this.Relabel2.Click += new System.EventHandler(this.Relabel2_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.RegisterLabel.Location = new System.Drawing.Point(321, 55);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(90, 36);
            this.RegisterLabel.TabIndex = 5;
            this.RegisterLabel.Text = "注册";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.Relabel2);
            this.Controls.Add(this.Relabel1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.RegisterBox2);
            this.Controls.Add(this.RegisterBox1);
            this.Name = "Form_Register";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label RegisterLabel;

        private System.Windows.Forms.Label Relabel2;

        private System.Windows.Forms.Label Relabel1;

        private System.Windows.Forms.Button Register;

        private System.Windows.Forms.TextBox RegisterBox2;

        private System.Windows.Forms.TextBox RegisterBox1;

        #endregion
    }
}