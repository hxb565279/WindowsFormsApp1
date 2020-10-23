using System.ComponentModel;

namespace WindowsFormsApp4
{
    partial class Receipt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.查询ToolStripMenuItem, this.插入ToolStripMenuItem, this.删除ToolStripMenuItem, this.添加ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1105, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip1";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.全查询ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 全查询ToolStripMenuItem
            // 
            this.全查询ToolStripMenuItem.Name = "全查询ToolStripMenuItem";
            this.全查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.全查询ToolStripMenuItem.Text = "全查询";
            this.全查询ToolStripMenuItem.Click += new System.EventHandler(this.全查询ToolStripMenuItem_Click);
            // 
            // 插入ToolStripMenuItem
            // 
            this.插入ToolStripMenuItem.Name = "插入ToolStripMenuItem";
            this.插入ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.插入ToolStripMenuItem.Text = "插入";
            this.插入ToolStripMenuItem.Click += new System.EventHandler(this.插入ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.添加ToolStripMenuItem.Text = "更改";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Receipt";
            this.Text = "收货单";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem 插入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全查询ToolStripMenuItem;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}