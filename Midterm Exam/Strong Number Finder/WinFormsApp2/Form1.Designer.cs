namespace WinFormsApp2
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
            this.tb_number = new System.Windows.Forms.TextBox();
            this.btn_tolist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_strong = new System.Windows.Forms.Label();
            this.btn_fromlist = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(51, 94);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(100, 23);
            this.tb_number.TabIndex = 0;
            // 
            // btn_tolist
            // 
            this.btn_tolist.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tolist.Location = new System.Drawing.Point(319, 67);
            this.btn_tolist.Name = "btn_tolist";
            this.btn_tolist.Size = new System.Drawing.Size(125, 50);
            this.btn_tolist.TabIndex = 1;
            this.btn_tolist.Text = "> > > >";
            this.btn_tolist.UseVisualStyleBackColor = true;
            this.btn_tolist.Click += new System.EventHandler(this.btn_tolist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // lb_strong
            // 
            this.lb_strong.AutoSize = true;
            this.lb_strong.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_strong.Location = new System.Drawing.Point(12, 219);
            this.lb_strong.Name = "lb_strong";
            this.lb_strong.Size = new System.Drawing.Size(277, 47);
            this.lb_strong.TabIndex = 3;
            this.lb_strong.Text = "Strong Number";
            this.lb_strong.Visible = false;
            // 
            // btn_fromlist
            // 
            this.btn_fromlist.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fromlist.Location = new System.Drawing.Point(319, 263);
            this.btn_fromlist.Name = "btn_fromlist";
            this.btn_fromlist.Size = new System.Drawing.Size(125, 50);
            this.btn_fromlist.TabIndex = 4;
            this.btn_fromlist.Text = "< < < <";
            this.btn_fromlist.UseVisualStyleBackColor = true;
            this.btn_fromlist.Click += new System.EventHandler(this.btn_fromlist_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(510, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 379);
            this.listBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "................";
            this.label3.Visible = false;
            // 
            // lb_debug
            // 
            this.lb_debug.AutoSize = true;
            this.lb_debug.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_debug.Location = new System.Drawing.Point(310, 177);
            this.lb_debug.Name = "lb_debug";
            this.lb_debug.Size = new System.Drawing.Size(47, 17);
            this.lb_debug.TabIndex = 7;
            this.lb_debug.Text = "debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_debug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_fromlist);
            this.Controls.Add(this.lb_strong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tolist);
            this.Controls.Add(this.tb_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_number;
        private Button btn_tolist;
        private Label label1;
        private Label lb_strong;
        private Button btn_fromlist;
        private ListBox listBox1;
        private Label label3;
        private Label lb_debug;
    }
}