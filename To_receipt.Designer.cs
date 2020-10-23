using System.ComponentModel;

namespace WindowsFormsApp4
{
    partial class To_receipt
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
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.menuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip4
            // 
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.主页ToolStripMenuItem, this.查询ToolStripMenuItem, this.删除ToolStripMenuItem, this.修改ToolStripMenuItem, this.增加ToolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(1203, 28);
            this.menuStrip4.TabIndex = 0;
            this.menuStrip4.Text = "menuStrip4";
            this.menuStrip4.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip4_ItemClicked);
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.主页ToolStripMenuItem.Text = "主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.增加ToolStripMenuItem.Text = "增加";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 118);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(1203, 320);
            this.dataGridView4.TabIndex = 1;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // To_receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 450);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.menuStrip4);
            this.MainMenuStrip = this.menuStrip4;
            this.Name = "To_receipt";
            this.Text = "发件单";
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView4;

        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;

        #endregion
    }
}