using System.ComponentModel;

namespace WindowsFormsApp4
{
    partial class select1
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
            this.shopname1 = new System.Windows.Forms.TextBox();
            this.receipt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectbutton1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // shopname1
            // 
            this.shopname1.Location = new System.Drawing.Point(81, 41);
            this.shopname1.Name = "shopname1";
            this.shopname1.Size = new System.Drawing.Size(94, 25);
            this.shopname1.TabIndex = 0;
            this.shopname1.TextChanged += new System.EventHandler(this.shopname1_TextChanged);
            // 
            // receipt
            // 
            this.receipt.Location = new System.Drawing.Point(294, 41);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(102, 25);
            this.receipt.TabIndex = 1;
            this.receipt.TextChanged += new System.EventHandler(this.receipt_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectbutton1
            // 
            this.selectbutton1.Location = new System.Drawing.Point(638, 41);
            this.selectbutton1.Name = "selectbutton1";
            this.selectbutton1.Size = new System.Drawing.Size(75, 24);
            this.selectbutton1.TabIndex = 3;
            this.selectbutton1.Text = "查询";
            this.selectbutton1.UseVisualStyleBackColor = true;
            this.selectbutton1.Click += new System.EventHandler(this.selectbutton1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(2, 121);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(798, 328);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "商品名:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(220, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "收件人:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(415, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "发件人:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // select1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.selectbutton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.shopname1);
            this.Name = "select1";
            this.Text = "select1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView dataGridView3;

        private System.Windows.Forms.Button selectbutton1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox receipt;

        private System.Windows.Forms.TextBox shopname1;

        #endregion
    }
}