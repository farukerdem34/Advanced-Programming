namespace WinFormsApp5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_panel_1 = new System.Windows.Forms.Button();
            this.tb_phonenumber = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close_panel_2 = new System.Windows.Forms.Button();
            this.btn_search_panel_2 = new System.Windows.Forms.Button();
            this.tb_searchno_panel_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_delete_panel_4 = new System.Windows.Forms.Button();
            this.tb_searchno_panel_4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_close_panel_3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Book";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(12, 145);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 39);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_list
            // 
            this.btn_list.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_list.Location = new System.Drawing.Point(12, 190);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(107, 39);
            this.btn_list.TabIndex = 2;
            this.btn_list.Text = "List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(12, 235);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 39);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(12, 280);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 39);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.btn_add_panel_1);
            this.panel1.Controls.Add(this.tb_phonenumber);
            this.panel1.Controls.Add(this.tb_surname);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_number);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(169, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 172);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // btn_add_panel_1
            // 
            this.btn_add_panel_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_panel_1.Location = new System.Drawing.Point(170, 146);
            this.btn_add_panel_1.Name = "btn_add_panel_1";
            this.btn_add_panel_1.Size = new System.Drawing.Size(59, 23);
            this.btn_add_panel_1.TabIndex = 17;
            this.btn_add_panel_1.Text = "Add";
            this.btn_add_panel_1.UseVisualStyleBackColor = true;
            this.btn_add_panel_1.Click += new System.EventHandler(this.btn_add_panel_1_Click);
            // 
            // tb_phonenumber
            // 
            this.tb_phonenumber.Location = new System.Drawing.Point(129, 101);
            this.tb_phonenumber.Name = "tb_phonenumber";
            this.tb_phonenumber.Size = new System.Drawing.Size(100, 23);
            this.tb_phonenumber.TabIndex = 7;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(129, 68);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 23);
            this.tb_surname.TabIndex = 6;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(129, 35);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 23);
            this.tb_name.TabIndex = 5;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(129, 6);
            this.tb_number.Name = "tb_number";
            this.tb_number.ReadOnly = true;
            this.tb_number.Size = new System.Drawing.Size(100, 23);
            this.tb_number.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.btn_close_panel_2);
            this.panel2.Controls.Add(this.btn_search_panel_2);
            this.panel2.Controls.Add(this.tb_searchno_panel_2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(407, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 172);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // btn_close_panel_2
            // 
            this.btn_close_panel_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close_panel_2.Location = new System.Drawing.Point(131, 125);
            this.btn_close_panel_2.Name = "btn_close_panel_2";
            this.btn_close_panel_2.Size = new System.Drawing.Size(59, 23);
            this.btn_close_panel_2.TabIndex = 16;
            this.btn_close_panel_2.Text = "Close";
            this.btn_close_panel_2.UseVisualStyleBackColor = true;
            this.btn_close_panel_2.Click += new System.EventHandler(this.btn_close_panel_2_Click);
            // 
            // btn_search_panel_2
            // 
            this.btn_search_panel_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search_panel_2.Location = new System.Drawing.Point(131, 96);
            this.btn_search_panel_2.Name = "btn_search_panel_2";
            this.btn_search_panel_2.Size = new System.Drawing.Size(59, 23);
            this.btn_search_panel_2.TabIndex = 15;
            this.btn_search_panel_2.Text = "Search";
            this.btn_search_panel_2.UseVisualStyleBackColor = true;
            this.btn_search_panel_2.Click += new System.EventHandler(this.btn_search_panel_2_Click);
            // 
            // tb_searchno_panel_2
            // 
            this.tb_searchno_panel_2.Location = new System.Drawing.Point(73, 97);
            this.tb_searchno_panel_2.Name = "tb_searchno_panel_2";
            this.tb_searchno_panel_2.Size = new System.Drawing.Size(52, 23);
            this.tb_searchno_panel_2.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Search No";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 64);
            this.listBox1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(152, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "P. Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(90, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Surname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "No";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Controls.Add(this.btn_delete_panel_4);
            this.panel4.Controls.Add(this.tb_searchno_panel_4);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(407, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 172);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // btn_delete_panel_4
            // 
            this.btn_delete_panel_4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_panel_4.Location = new System.Drawing.Point(141, 74);
            this.btn_delete_panel_4.Name = "btn_delete_panel_4";
            this.btn_delete_panel_4.Size = new System.Drawing.Size(59, 23);
            this.btn_delete_panel_4.TabIndex = 17;
            this.btn_delete_panel_4.Text = "Delete";
            this.btn_delete_panel_4.UseVisualStyleBackColor = true;
            this.btn_delete_panel_4.Click += new System.EventHandler(this.btn_delete_panel_4_Click);
            // 
            // tb_searchno_panel_4
            // 
            this.tb_searchno_panel_4.Location = new System.Drawing.Point(85, 75);
            this.tb_searchno_panel_4.Name = "tb_searchno_panel_4";
            this.tb_searchno_panel_4.Size = new System.Drawing.Size(52, 23);
            this.tb_searchno_panel_4.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(15, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Search No";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.btn_close_panel_3);
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(169, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 172);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // btn_close_panel_3
            // 
            this.btn_close_panel_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close_panel_3.Location = new System.Drawing.Point(170, 146);
            this.btn_close_panel_3.Name = "btn_close_panel_3";
            this.btn_close_panel_3.Size = new System.Drawing.Size(59, 23);
            this.btn_close_panel_3.TabIndex = 16;
            this.btn_close_panel_3.Text = "Close";
            this.btn_close_panel_3.UseVisualStyleBackColor = true;
            this.btn_close_panel_3.Click += new System.EventHandler(this.btn_close_panel_3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(3, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(226, 64);
            this.listBox2.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(152, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "P. Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(90, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Surname";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(39, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_add;
        private Button btn_list;
        private Button btn_search;
        private Button btn_delete;
        private Panel panel1;
        private TextBox tb_phonenumber;
        private TextBox tb_surname;
        private TextBox tb_name;
        private TextBox tb_number;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private TextBox tb_searchno_panel_2;
        private Label label10;
        private ListBox listBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel4;
        private Button btn_close_panel_2;
        private Button btn_search_panel_2;
        private Button btn_delete_panel_4;
        private TextBox tb_searchno_panel_4;
        private Label label11;
        private Panel panel3;
        private Button btn_close_panel_3;
        private ListBox listBox2;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button btn_add_panel_1;
    }
}