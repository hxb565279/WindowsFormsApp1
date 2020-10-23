using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
                全查询ToolStripMenuItem_Click(null,null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // this.Show();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public void 全查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlConnection conn = db.getConn();
            try
            {
                String sql = String.Format("select * from receipt  ");
                MySqlCommand comm = new MySqlCommand(sql, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = comm;
                //数据集
                DataSet ds = new DataSet();
                sda.Fill(ds, "receipt");

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "商品名";
                dataGridView1.Columns[2].HeaderText = "价格";
                dataGridView1.Columns[3].HeaderText = "数量";
                dataGridView1.Columns[4].HeaderText = "收件人";
                dataGridView1.Columns[5].HeaderText = "发件人";
                dataGridView1.Columns[6].HeaderText = "电话";
                dataGridView1.Columns[7].HeaderText = "用户";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString() + "打开数据库错误");
            }
            finally
            {
                conn.Close();
            }
        }

        private void 插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                int index = dataGridView1.CurrentRow.Index;
                String value0 = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String value1 = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String value2 = dataGridView1.Rows[index].Cells[2].Value.ToString();
                String value3 = dataGridView1.Rows[index].Cells[3].Value.ToString();
                String value4 = dataGridView1.Rows[index].Cells[4].Value.ToString();
                String value5 = dataGridView1.Rows[index].Cells[5].Value.ToString();
                String value6 = dataGridView1.Rows[index].Cells[6].Value.ToString();
                String value7 = dataGridView1.Rows[index].Cells[7].Value.ToString();
                String sql = String.Format(
                    "insert into receipt (receipt_id,receipt_shopname,receipt_price,receipt_number," +
                    "receipt_person,person,receipt_person_phone,login) " +
                    "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", value0, value1
                    , value2, value3, value4, value5, value6, value7);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("插入成功");
                全查询ToolStripMenuItem_Click(sender, e);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString() + "数据库打开失败");
            }
            finally
            {
                conn.Close();
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                int index = dataGridView1.CurrentRow.Index;
                String value = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String sql = String.Format("delete from receipt where receipt_id = '{0}'", value);
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("删除成功");
                this.全查询ToolStripMenuItem_Click(sender, e);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString() + "数据库打开失败");
            }
            finally
            {
                conn.Close();
            }
        }

        /**
 * 更改
 */
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlConnection conn = db.getConn();
            try
            {
                conn.Open();
                int index = dataGridView1.CurrentRow.Index;
                String value = dataGridView1.Rows[index].Cells[0].Value.ToString();
                String value0 = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String value1 = dataGridView1.Rows[index].Cells[2].Value.ToString();
                String value2 = dataGridView1.Rows[index].Cells[3].Value.ToString();
                String value3 = dataGridView1.Rows[index].Cells[4].Value.ToString();
                String value4 = dataGridView1.Rows[index].Cells[5].Value.ToString();
                String value5 = dataGridView1.Rows[index].Cells[6].Value.ToString();
                String value6 = dataGridView1.Rows[index].Cells[7].Value.ToString();
                String sql = String.Format("update receipt set receipt_shopname='{0}',receipt_price='{1}',receipt_number='{2}' ," +
                                           "receipt_person='{3}',person='{4}',receipt_person_phone='{5}',login= '{6}' where receipt_id='{7}'",value0,
                    value1,value2,value3,value4,value5,value6,value);
                MySqlCommand comm = new MySqlCommand(sql,conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("修改成功");
                全查询ToolStripMenuItem_Click(sender,e);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message.ToString() + "打开数据库失败");
            }
            finally
            {
                conn.Close();
            }
        }

       
    }
}