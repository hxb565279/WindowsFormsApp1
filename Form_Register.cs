using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void RegisterBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void RegisterBox2_TextChanged(object sender, EventArgs e)
        {
        }

        public void user()
        {
            
        }
        
        private void Register_Click(object sender, EventArgs e)
        {
            String username = this.RegisterBox1.Text;
            String password = this.RegisterBox2.Text;
            Database db = new Database();
            MySqlConnection conn = db.getConn();
            if (username.Equals(""))
            {
                MessageBox.Show("账号为空");
            }
            else
            {
                if (password.Equals(""))
                {
                    MessageBox.Show("密码为空");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("打开数据库成功");
                        String sql = String.Format("insert into users (userid,userpwd) values('{0}','{1}')", username,
                            password);
                        String sql1 = String.Format("select * from users where userid = '{0}'", username);
                        MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                        MySqlCommand mySqlCommand1 = new MySqlCommand(sql1, conn);
                        if (Convert.ToInt32(mySqlCommand1.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("该账户已经存在,请登录");
                            Form1.form1.登录ToolStripMenuItem_Click(null,null);
                        }
                        else
                        {
                            mySqlCommand.ExecuteNonQuery();
                            MessageBox.Show("注册成功");
                            Form1.form1.登录ToolStripMenuItem_Click(null,null);
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        MessageBox.Show(exception.Message.ToString() + ("打开数据库失败"));
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void Relabel1_Click(object sender, EventArgs e)
        {
        }

        private void Relabel2_Click(object sender, EventArgs e)
        {
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
        }
    }
}