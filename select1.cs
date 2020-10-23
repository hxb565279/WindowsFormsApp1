using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class select1 : Form
    {
        public select1()
        {
            InitializeComponent();
        }

        private void shopname1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void receipt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void selectbutton1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlConnection conn = db.getConn();
            try
            {
                String shopname = this.shopname1.Text;
                String receipt_person = this.receipt.Text;
                String person = this.textBox1.Text;
               conn.Open();
               String sql = String.Format("select * from receipt where receipt_shopname = '{0}' and receipt_person = '{1}'  and person = '{2}' ", shopname, receipt_person, person);
               MySqlCommand comm= new MySqlCommand(sql,conn);
               MySqlDataAdapter sda = new MySqlDataAdapter();
               sda.SelectCommand = comm;
               //数据集
               DataSet ds = new DataSet();
               sda.Fill(ds, "receipt");
               dataGridView3.DataSource = ds.Tables[0];
               dataGridView3.Columns[0].HeaderText = "id";
               dataGridView3.Columns[1].HeaderText = "商品名";
               dataGridView3.Columns[2].HeaderText = "价格";
               dataGridView3.Columns[3].HeaderText = "数量";
               dataGridView3.Columns[4].HeaderText = "收件人";
               dataGridView3.Columns[5].HeaderText = "发件人";
               dataGridView3.Columns[6].HeaderText = "电话";
               dataGridView3.Columns[7].HeaderText = "用户";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}