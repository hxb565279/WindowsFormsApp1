namespace WindowsFormsApp4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发货单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账户查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.条件查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收件单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发件单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.文件ToolStripMenuItem, this.订单ToolStripMenuItem, this.账户ToolStripMenuItem, this.条件查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 订单ToolStripMenuItem
            // 
            this.订单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.收货单ToolStripMenuItem, this.发货单ToolStripMenuItem});
            this.订单ToolStripMenuItem.Name = "订单ToolStripMenuItem";
            this.订单ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.订单ToolStripMenuItem.Text = "订单";
            // 
            // 收货单ToolStripMenuItem
            // 
            this.收货单ToolStripMenuItem.Name = "收货单ToolStripMenuItem";
            this.收货单ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.收货单ToolStripMenuItem.Text = "收货单";
            this.收货单ToolStripMenuItem.Click += new System.EventHandler(this.收货单ToolStripMenuItem_Click);
            // 
            // 发货单ToolStripMenuItem
            // 
            this.发货单ToolStripMenuItem.Name = "发货单ToolStripMenuItem";
            this.发货单ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.发货单ToolStripMenuItem.Text = "发货单";
            this.发货单ToolStripMenuItem.Click += new System.EventHandler(this.发货单ToolStripMenuItem_Click);
            // 
            // 账户ToolStripMenuItem
            // 
            this.账户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.登录ToolStripMenuItem, this.注册ToolStripMenuItem, this.账户查询ToolStripMenuItem});
            this.账户ToolStripMenuItem.Name = "账户ToolStripMenuItem";
            this.账户ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.账户ToolStripMenuItem.Text = "账户";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.注册ToolStripMenuItem.Text = "注册";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // 账户查询ToolStripMenuItem
            // 
            this.账户查询ToolStripMenuItem.Name = "账户查询ToolStripMenuItem";
            this.账户查询ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.账户查询ToolStripMenuItem.Text = "账户查询";
            this.账户查询ToolStripMenuItem.Click += new System.EventHandler(this.账户查询ToolStripMenuItem_Click);
            // 
            // 条件查询ToolStripMenuItem
            // 
            this.条件查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.收件单ToolStripMenuItem, this.发件单ToolStripMenuItem});
            this.条件查询ToolStripMenuItem.Name = "条件查询ToolStripMenuItem";
            this.条件查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.条件查询ToolStripMenuItem.Text = "条件查询";
            this.条件查询ToolStripMenuItem.Click += new System.EventHandler(this.条件查询ToolStripMenuItem_Click);
            // 
            // 收件单ToolStripMenuItem
            // 
            this.收件单ToolStripMenuItem.Name = "收件单ToolStripMenuItem";
            this.收件单ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.收件单ToolStripMenuItem.Text = "收件单";
            this.收件单ToolStripMenuItem.Click += new System.EventHandler(this.收件单ToolStripMenuItem_Click);
            // 
            // 发件单ToolStripMenuItem
            // 
            this.发件单ToolStripMenuItem.Name = "发件单ToolStripMenuItem";
            this.发件单ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.发件单ToolStripMenuItem.Text = "发件单";
            this.发件单ToolStripMenuItem.Click += new System.EventHandler(this.发件单ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(117, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "欢迎进入管理系统";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolStripMenuItem 发件单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收件单ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 条件查询ToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收货单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账户查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;

        #endregion
    }
}