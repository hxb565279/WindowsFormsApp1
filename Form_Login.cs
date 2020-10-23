using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.Security;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp4
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void LoginBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void LoginBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username = this.LoginBox1.Text;
            String password = this.LoginBox2.Text;
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
                        String sql = String.Format("select * from users where userid = '{0}' and userpwd = '{1}'",
                            username,
                            password);
                        String sql1 = String.Format("select * from users where userid = '{0}'", username);
                        MySqlCommand comm = new MySqlCommand(sql, conn);
                        MySqlCommand comm1 = new MySqlCommand(sql1, conn);
                        if (Convert.ToInt32(comm1.ExecuteScalar()) > 0)
                        {
                            if (Convert.ToInt32(comm.ExecuteScalar()) > 0)
                            {
                                MessageBox.Show("登录成功");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("账号或密码错误");
                            }
                        }
                        else
                        {
                            MessageBox.Show("账号不存在,请注册");
                            Form1.form1.注册ToolStripMenuItem_Click(null,null);
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        MessageBox.Show("数据库打开失败");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void Loginlabel1_Click(object sender, EventArgs e)
        {
        }

        private void Loginlabel2_Click(object sender, EventArgs e)
        {
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
        }
    }
}