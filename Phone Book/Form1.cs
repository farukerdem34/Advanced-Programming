namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rec = 1;
        string[] phone_book = new string[50];
        int i = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            tb_number.Text = rec.ToString();
            rec++;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btn_add_panel_1_Click(object sender, EventArgs e)
        {
            phone_book[i] = tb_number.Text + "\t" + tb_name.Text + "\t" + tb_surname.Text + "\t" + tb_phonenumber.Text;
            i++;
            tb_number.Text = "";
            tb_name.Text = "";
            tb_surname.Text = "";
            tb_phonenumber.Text = "";
            panel1.Visible = false;
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            foreach (string phone in phone_book)
            {
                if (phone != null)
                {
                    listBox2.Items.Add(phone);
                }
            }
        }

        private void btn_close_panel_3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btn_search_panel_2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string phone in phone_book)
            {
                if (phone != null)
                {

                    string[] vs = phone.Split('\t');
                    int no = int.Parse(vs[0]);
                    if (no == int.Parse(tb_searchno_panel_2.Text))
                    {
                        listBox1.Items.Add(phone);
                    }
                }
            }
            tb_searchno_panel_2.Text = "";

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            listBox1.Items.Clear();
        }

        private void btn_close_panel_2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            tb_searchno_panel_2.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void btn_delete_panel_4_Click(object sender, EventArgs e)
        {
            int no = int.Parse(tb_searchno_panel_4.Text.ToString());
            for (int i = 0; i < phone_book.Length; i++)
            {
                if (phone_book[i] != null)
                {
                    string[] vs = phone_book[i].Split('\t');
                    int _no = int.Parse(vs[0]);
                    if (no == _no)
                    {
                        phone_book[i] = null;
                    }
                }
            }
            tb_searchno_panel_4.Text = "";
        }
    }
}