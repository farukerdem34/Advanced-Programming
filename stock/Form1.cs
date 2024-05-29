using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnt = null;
        SqlCommand cmd = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;

        public void Fill_Table()
        {
            cnt = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=stock;Integrated Security=True");
            adp = new SqlDataAdapter("SELECT * FROM stock_table", cnt);
            ds = new DataSet();
            cnt.Open();
            adp.Fill(ds, "stock_table");
            dataGridView1.DataSource = ds.Tables["stock_table"];
            cnt.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill_Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cnt.Open();
            cmd.Connection = cnt;
            int total_price = calculate_total_price();

            cmd.CommandText = "INSERT INTO stock_table(date,class,item,count,price,tprice) VALUES" +
                "('" + dateTimePicker1.Value.ToString() + "','" + comboBox1.SelectedItem.ToString() + "','" + tb_name.Text + "','" + tb_count.Text + "','" + tb_price.Text + "','" + total_price.ToString() + "')";
            cmd.ExecuteNonQuery();
            cnt.Close();
            Fill_Table();
        }

        private int calculate_total_price()
        {
            int price = Convert.ToInt32(tb_price.Text);
            int total_price = Convert.ToInt32(tb_count.Text) * price;
            return total_price;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cnt.Open();
            cmd.Connection = cnt;
            cmd.CommandText = "DELETE FROM stock_table WHERE id='" + tb_id.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            cnt.Close();
            Fill_Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total_price = calculate_total_price();
            cmd = new SqlCommand();
            cnt.Open();
            cmd.Connection = cnt;
            cmd.CommandText = "UPDATE stock_table " +
                "date='"+dateTimePicker1.Value.ToString()+"',class='"+comboBox1.SelectedItem.ToString()+"'," +
                "item='"+tb_name.Text+"',count='"+tb_count.Text+"',price='"+tb_price.Text+"'," +
                "tprice='"+total_price.ToString()+"' " +
                "WHERE id='"+tb_id.Text+"'";
            cmd.ExecuteNonQuery();
            cnt.Close();
            Fill_Table();
        }
    }
}
