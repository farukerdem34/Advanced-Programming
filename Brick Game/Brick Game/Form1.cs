using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Brick_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Panel[] get_targets()
        {
            Panel[] targets = { target1, target2, target3, target4, target5 };
            return targets;
        }
        public void go_down(Panel[] targets, int speed)
        {
            foreach (Panel target in targets)
            {
                target.Top += speed;
            }
        }
        bool firing = false;
        const int speed_val = 2;
        int up_border = -77,down_border=557;
        bool run = true, win = true;
        public void control_player(Keys pressed_key, int speed)
        {
            void fire()
            {
                firing = true;
            }
            switch (pressed_key)
            {
                case Keys.Right: player.Left += speed; if(!firing) ammo.Left += speed; break;
                case Keys.Left: player.Left -= speed; if (!firing) ammo.Left -= speed; break;
                case Keys.Up:fire();break;
            }
        }
        public void ammo_go_back()
        {
            firing = false;
            int y = 460;
            ammo.Top = y;
            ammo.Left = player.Left;
        }
        public void firing_ammo(int speed)
        {
            ammo.Top -= speed;
        }

        public void shot(Panel[] targets)
        {
            foreach (Panel target in targets)
            {
                int left = target.Left;
                if(ammo.Left>left && ammo.Left <= (left + 75))
                {
                    target.BackColor = Color.Yellow;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (run)
            {

                Panel[] targets = get_targets();
                go_down(targets, speed_val);
                if (firing)
                {
                    firing_ammo(speed_val * 5);
                }
                if (ammo.Top <= up_border)
                {
                    ammo_go_back();
                }
                void check_targets(Panel[] targets)
                {
                    foreach (Panel target in targets)
                    {
                        if (target.Top >= down_border&&target.BackColor!=Color.Yellow)
                        {
                            win = false;
                            run = false;
                        }
                    }
                }
                shot(targets);
                check_targets(targets);
            }
            else
            {
                timer1.Start();
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (run)
            {

            control_player(e.KeyCode,speed_val*2);
            }
        }
    }
}
