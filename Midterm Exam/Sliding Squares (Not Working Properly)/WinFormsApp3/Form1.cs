namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool pending = false;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop(this, DragDropEffects.Copy);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (!pending)
            {
                Panel panel = e.Data.ToString();
                foreach (string format in panel)
                {
                    label1.Text += format;
                }

                panel8.BackColor = panel.BackColor;
                timer1.Start();
            }
            

            
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pending = true;
            panel8.Top += 2;
            if (panel8.Top > 450)
            {
                panel8.Top = 20;
                pending = false;
                timer1.Stop();
            }
        }
    }
}