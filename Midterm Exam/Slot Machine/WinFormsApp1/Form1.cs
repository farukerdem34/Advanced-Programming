namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n1, n2, n3;

        private void start_timer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            n1 = random.Next(1,10);
            n2 = random.Next(1, 10);
            n3 = random.Next(1, 10);
            label1.Text = n1.ToString();
            label2.Text = n2.ToString();
            label3.Text = n3.ToString();
            label4.Text=n1.ToString()+n2.ToString()+n3.ToString();
            if (n1==n2&&n2==n3)
            {
                timer1.Stop();
                label4.BackColor = Color.Green;
            }
        }
    }
}