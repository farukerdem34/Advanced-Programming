namespace Brick_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            target1 = new Panel();
            target2 = new Panel();
            target3 = new Panel();
            target4 = new Panel();
            target5 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            player = new Panel();
            ammo = new Panel();
            SuspendLayout();
            // 
            // target1
            // 
            target1.BackColor = Color.MediumBlue;
            target1.Location = new Point(12, 12);
            target1.Name = "target1";
            target1.Size = new Size(75, 75);
            target1.TabIndex = 0;
            // 
            // target2
            // 
            target2.BackColor = Color.MediumBlue;
            target2.Location = new Point(148, 116);
            target2.Name = "target2";
            target2.Size = new Size(75, 75);
            target2.TabIndex = 1;
            // 
            // target3
            // 
            target3.BackColor = Color.MediumBlue;
            target3.Location = new Point(287, 29);
            target3.Name = "target3";
            target3.Size = new Size(75, 75);
            target3.TabIndex = 2;
            // 
            // target4
            // 
            target4.BackColor = Color.MediumBlue;
            target4.Location = new Point(411, 116);
            target4.Name = "target4";
            target4.Size = new Size(75, 75);
            target4.TabIndex = 2;
            // 
            // target5
            // 
            target5.BackColor = Color.MediumBlue;
            target5.Location = new Point(535, 60);
            target5.Name = "target5";
            target5.Size = new Size(75, 75);
            target5.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // player
            // 
            player.BackColor = Color.Violet;
            player.Location = new Point(287, 541);
            player.Name = "player";
            player.Size = new Size(75, 75);
            player.TabIndex = 2;
            // 
            // ammo
            // 
            ammo.BackColor = Color.Violet;
            ammo.Location = new Point(287, 460);
            ammo.Name = "ammo";
            ammo.Size = new Size(75, 74);
            ammo.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(632, 628);
            Controls.Add(ammo);
            Controls.Add(player);
            Controls.Add(target5);
            Controls.Add(target4);
            Controls.Add(target3);
            Controls.Add(target2);
            Controls.Add(target1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Panel target1;
        private Panel target2;
        private Panel target3;
        private Panel target4;
        private Panel target5;
        private System.Windows.Forms.Timer timer1;
        private Panel player;
        private Panel ammo;
    }
}
