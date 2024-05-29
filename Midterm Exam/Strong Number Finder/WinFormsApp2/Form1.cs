namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        bool is_strong = false;
        private void btn_tolist_Click(object sender, EventArgs e)
        {
            is_strong = false;
            listBox1.Items.Clear();
            string number_str = tb_number.Text;
            int number = int.Parse(number_str);
            char[] basamaklar = new char[number_str.Length];
            for (int i = 0; i < basamaklar.Length; i++)
            {
                basamaklar[i] = number_str[i];
                listBox1.Items.Add(number_str[i]);
            }

            int sum = 0, temp = 1;
            foreach (char basamak in basamaklar)
            {
                int basamak_int = int.Parse(basamak.ToString());
                temp = 1;
                for (int i = 1; i <= basamak_int; i++)
                {
                    if (i != 0 && temp != 0)
                        temp = temp * i;
                }
                sum += temp;
            }

            if(sum == number)
            {
                is_strong = true;
                label3.Text=number.ToString();
            }
        }

        private void btn_fromlist_Click(object sender, EventArgs e)
        {
            lb_strong.Visible = false;
            if (is_strong)
            {
                lb_strong.Visible = true;
            }
        }
    }
}