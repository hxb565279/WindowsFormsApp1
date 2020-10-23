using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
            this.BackgroundImage = Image.FromFile("E:\\idea-images\\1.jpg");
        }

       
   


        public void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form1 in this.MdiChildren)
            {
                form1.Close();
            }
            Form_Login formLogin = new Form_Login();
            formLogin.MdiParent = this;
            formLogin.FormBorderStyle = FormBorderStyle.None;
            formLogin.Dock = DockStyle.Fill;
            formLogin.Show();
        }

        public void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            Form_Register formRegister = new Form_Register();
            formRegister.MdiParent = this;
            formRegister.FormBorderStyle = FormBorderStyle.None;
            formRegister.Dock = DockStyle.Fill;
            formRegister.Show();
        }

        private void 收货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            Receipt receipt = new Receipt();
            receipt.MdiParent = this;
            receipt.FormBorderStyle = FormBorderStyle.None;
            receipt.Dock = DockStyle.Fill;
            receipt.Show();
        }

        private void 发货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            To_receipt toReceipt= new To_receipt();
            toReceipt.MdiParent = this;
            toReceipt.FormBorderStyle = FormBorderStyle.None;
            toReceipt.Dock = DockStyle.Fill;
            toReceipt.Show();
        }

        private void 账户查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 条件查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void 收件单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            select1 s = new select1();
            s.MdiParent = this;
            s.FormBorderStyle = FormBorderStyle.None;
            s.Dock = DockStyle.Fill;
            s.Show();
        }

        private void 发件单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            To_receipt s = new To_receipt();
            s.MdiParent = this;
            s.FormBorderStyle = FormBorderStyle.None;
            s.Dock = DockStyle.Fill;
            s.Show();
        }
    }
}