namespace ParkingSystem
{
    partial class enduser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.vtype = new System.Windows.Forms.ComboBox();
            this.vnumber = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depart = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.bill = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sumbit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.enter.SuspendLayout();
            this.depart.SuspendLayout();
            this.bill.SuspendLayout();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Controls.Add(this.time);
            this.enter.Controls.Add(this.vtype);
            this.enter.Controls.Add(this.vnumber);
            this.enter.Controls.Add(this.button2);
            this.enter.Controls.Add(this.button1);
            this.enter.Controls.Add(this.label3);
            this.enter.Controls.Add(this.label2);
            this.enter.Controls.Add(this.label1);
            this.enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter.Location = new System.Drawing.Point(0, 0);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(467, 379);
            this.enter.TabIndex = 0;
            this.enter.Paint += new System.Windows.Forms.PaintEventHandler(this.enter_Paint);
            // 
            // time
            // 
            this.time.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.time.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(219, 187);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(222, 28);
            this.time.TabIndex = 6;
            this.time.Value = new System.DateTime(2023, 9, 20, 11, 51, 0, 0);
            // 
            // vtype
            // 
            this.vtype.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtype.FormattingEnabled = true;
            this.vtype.Items.AddRange(new object[] {
            "Car",
            "Bike"});
            this.vtype.Location = new System.Drawing.Point(230, 133);
            this.vtype.Name = "vtype";
            this.vtype.Size = new System.Drawing.Size(164, 28);
            this.vtype.TabIndex = 5;
            // 
            // vnumber
            // 
            this.vnumber.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vnumber.Location = new System.Drawing.Point(226, 78);
            this.vnumber.Name = "vnumber";
            this.vnumber.Size = new System.Drawing.Size(199, 28);
            this.vnumber.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(251, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date and Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehical Category: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehical Number: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // depart
            // 
            this.depart.Controls.Add(this.button3);
            this.depart.Controls.Add(this.combo);
            this.depart.Controls.Add(this.bill);
            this.depart.Controls.Add(this.sumbit);
            this.depart.Controls.Add(this.label4);
            this.depart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depart.Location = new System.Drawing.Point(0, 0);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(467, 379);
            this.depart.TabIndex = 7;
            this.depart.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(267, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Go Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // combo
            // 
            this.combo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(213, 55);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(179, 28);
            this.combo.TabIndex = 7;
            // 
            // bill
            // 
            this.bill.Controls.Add(this.textBox4);
            this.bill.Controls.Add(this.label7);
            this.bill.Controls.Add(this.textBox3);
            this.bill.Controls.Add(this.label6);
            this.bill.Location = new System.Drawing.Point(12, 197);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(413, 95);
            this.bill.TabIndex = 6;
            this.bill.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(212, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 28);
            this.textBox4.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Location: ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(210, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 28);
            this.textBox3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount: ";
            // 
            // sumbit
            // 
            this.sumbit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumbit.Location = new System.Drawing.Point(80, 132);
            this.sumbit.Name = "sumbit";
            this.sumbit.Size = new System.Drawing.Size(101, 37);
            this.sumbit.TabIndex = 5;
            this.sumbit.Text = "Sumbit";
            this.sumbit.UseVisualStyleBackColor = true;
            this.sumbit.Click += new System.EventHandler(this.sumbit_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vehical Number: ";
            // 
            // enduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 379);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.enter);
            this.Name = "enduser";
            this.Text = "Enter Or Depart";
            this.Load += new System.EventHandler(this.enduser_Load);
            this.enter.ResumeLayout(false);
            this.enter.PerformLayout();
            this.depart.ResumeLayout(false);
            this.depart.PerformLayout();
            this.bill.ResumeLayout(false);
            this.bill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vnumber;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.ComboBox vtype;
        private System.Windows.Forms.Panel depart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sumbit;
        private System.Windows.Forms.Panel bill;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Button button3;
    }
}