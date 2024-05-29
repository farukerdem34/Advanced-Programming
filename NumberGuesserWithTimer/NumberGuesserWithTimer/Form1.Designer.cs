namespace NumberGuesserWithTimer
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
            btn_start = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_guess = new Button();
            label2 = new Label();
            lb_try = new Label();
            lb_score = new Label();
            label5 = new Label();
            lb_time = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_start.Location = new Point(114, 21);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(99, 33);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(20, 77);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Number:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(114, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += guess_by_enter;
            // 
            // btn_guess
            // 
            btn_guess.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_guess.Location = new Point(261, 74);
            btn_guess.Name = "btn_guess";
            btn_guess.Size = new Size(99, 33);
            btn_guess.TabIndex = 3;
            btn_guess.Text = "Guess";
            btn_guess.UseVisualStyleBackColor = true;
            btn_guess.Click += btn_guess_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(22, 162);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 4;
            label2.Text = "Try:";
            // 
            // lb_try
            // 
            lb_try.AutoSize = true;
            lb_try.BackColor = Color.LightSalmon;
            lb_try.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lb_try.Location = new Point(114, 162);
            lb_try.Name = "lb_try";
            lb_try.Size = new Size(23, 25);
            lb_try.TabIndex = 5;
            lb_try.Text = "5";
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.BackColor = Color.LightSalmon;
            lb_score.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lb_score.Location = new Point(114, 255);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(56, 25);
            lb_score.TabIndex = 7;
            lb_score.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(22, 255);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 6;
            label5.Text = "Score:";
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lb_time.Location = new Point(218, 333);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(55, 25);
            lb_time.TabIndex = 8;
            lb_time.Text = "Time";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 381);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(481, 57);
            progressBar1.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(progressBar1);
            Controls.Add(lb_time);
            Controls.Add(lb_score);
            Controls.Add(label5);
            Controls.Add(lb_try);
            Controls.Add(label2);
            Controls.Add(btn_guess);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_start;
        private Label label1;
        private TextBox textBox1;
        private Button btn_guess;
        private Label label2;
        private Label lb_try;
        private Label lb_score;
        private Label label5;
        private Label lb_time;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
