using System.CodeDom.Compiler;

namespace NumberGuesserWithTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 100;
        }
        bool run = true;
        int decrease_time = 1;
        int score = 1000, try_ = 5;
        int random_number = generate_random_number(1, 10);


        public void deactivate_all_btns()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btn_start.Enabled = false;
        }
        public static int generate_random_number(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max);
            return number;
        }

        public bool guess()
        {
            try
            {
                return (int.Parse(textBox1.Text.ToString()) == random_number);
            }
            catch
            {
                return false;
            }
        }
        public void check_result(bool result)
        {
            if (!result)
            {
                try_ -= 1;
                score -= 200;
                decrease_time += decrease_time;
                lb_score.Text = score.ToString();
                lb_try.Text = try_.ToString();
            }
            else
            {
                timer1.Stop();
                lb_score.BackColor = Color.Green;
                lb_time.Text = "You won!";
                deactivate_all_btns();
            }
        }
        private void btn_guess_Click(object sender, EventArgs e)
        {
            bool result = guess();
            check_result(result);
        }

        private void guess_by_enter(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && run)
            {
                bool result = guess();
                check_result(result);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!((progressBar1.Value - decrease_time) <= -1))
            {
                progressBar1.Value -= decrease_time;
            }
            
            if (try_<=0 || score<=0)
            {
                timer1.Stop();
                lb_time.Text = "You Lost! The number was " + random_number.ToString();
                run = false;
                deactivate_all_btns();
                progressBar1.Value = 0;
            }
        }
    }
}
