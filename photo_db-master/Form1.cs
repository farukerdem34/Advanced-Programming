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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        string conn_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=picture_db;Integrated Security=True;";
        void view_data()
        {
            conn = new SqlConnection(conn_string);
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM p_table", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog img_file = new OpenFileDialog();
            img_file.Filter = "image files |*.jpg;*.jpeg;*.png| All Files|*.*";
            img_file.ShowDialog();
            string file_path = img_file.FileName;
            tb_photo.Text = file_path;
            pictureBox1.ImageLocation = file_path;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_file = new SaveFileDialog();
            save_file.Filter = "image files |*.jpg;*.jpeg;*.png| All Files|*.*";
            save_file.ShowDialog();
            pictureBox1.Image.Save(save_file.FileName);
            MessageBox.Show("Image saved to images folder.");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO p_table(title,country,photographer,date,photo,keyfeature) VALUES " +
                "(@title,@country,@photographer,@date,@photo,@keyfeature)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@title", tb_title.Text.ToString());
            cmd.Parameters.AddWithValue("@country", tb_country.Text.ToString());
            cmd.Parameters.AddWithValue("@photographer", tb_photographer.Text.ToString());
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@photo", tb_photo.Text.ToString());
            cmd.Parameters.AddWithValue("@keyfeature", comboBox1.SelectedItem.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            view_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM p_table WHERE id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", tb_id.Text.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            view_data();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE p_table SET title=@title,country=@country,photographer=@photographer,date=@date" +
                ",photo=@photo,keyfeature@keyfeature WHERE id=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@title", tb_title.Text.ToString());
            cmd.Parameters.AddWithValue("@country", tb_country.Text.ToString());
            cmd.Parameters.AddWithValue("@photographer", tb_photographer.Text.ToString());
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@photo", tb_photo.Text.ToString());
            cmd.Parameters.AddWithValue("@keyfeature", comboBox1.SelectedItem.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            view_data();
        }

        private void select_row(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_title.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_country.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_photographer.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_photo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedItem= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = tb_photo.Text;
        }
    }
}
