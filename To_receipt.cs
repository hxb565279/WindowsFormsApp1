using System;
using System.Data;
using System.Management.Instrumentation;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class To_receipt : Form
    {
        public To_receipt()
        {
            InitializeComponent();
        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db= new Database();
            MySqlConnection conn = db.getConn();
            try
            {
                String sql = String.Format("select * from to_receipt");
                MySqlCommand comm = new MySqlCommand(sql,conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = comm;
                DataSet ds = new DataSet();
                sda.Fill(ds, "to_receipt");
                dataGridView4.DataSource=  ds.Tables[0];

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString()+ "打开数据库失败");
            }
            finally
            {
                conn.Close();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}