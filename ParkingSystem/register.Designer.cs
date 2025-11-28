namespace ParkingSystem
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Button();
            this.regpic1 = new System.Windows.Forms.PictureBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.mobno = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.dispass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.regpic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile Number:";
            // 
            // reg
            // 
            this.reg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.Location = new System.Drawing.Point(142, 326);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(148, 41);
            this.reg.TabIndex = 4;
            this.reg.Text = "Register";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // regpic1
            // 
            this.regpic1.Image = ((System.Drawing.Image)(resources.GetObject("regpic1.Image")));
            this.regpic1.Location = new System.Drawing.Point(404, -2);
            this.regpic1.Name = "regpic1";
            this.regpic1.Size = new System.Drawing.Size(396, 452);
            this.regpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regpic1.TabIndex = 5;
            this.regpic1.TabStop = false;
            // 
            // cname
            // 
            this.cname.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.Location = new System.Drawing.Point(201, 79);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(157, 28);
            this.cname.TabIndex = 6;
            // 
            // mobno
            // 
            this.mobno.AcceptsReturn = true;
            this.mobno.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobno.Location = new System.Drawing.Point(201, 128);
            this.mobno.Name = "mobno";
            this.mobno.Size = new System.Drawing.Size(157, 28);
            this.mobno.TabIndex = 7;
            // 
            // uname
            // 
            this.uname.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(201, 179);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(157, 28);
            this.uname.TabIndex = 8;
            this.uname.TextChanged += new System.EventHandler(this.uname_TextChanged);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(201, 226);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(157, 28);
            this.pass.TabIndex = 9;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // dispass
            // 
            this.dispass.Location = new System.Drawing.Point(201, 271);
            this.dispass.Name = "dispass";
            this.dispass.Size = new System.Drawing.Size(157, 23);
            this.dispass.TabIndex = 0;
            this.dispass.Text = "Show Password";
            this.dispass.UseVisualStyleBackColor = true;
            this.dispass.CheckedChanged += new System.EventHandler(this.dispass_CheckedChanged);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 425);
            this.Controls.Add(this.dispass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.mobno);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.regpic1);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.regpic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.PictureBox regpic1;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.TextBox mobno;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox dispass;
    }
}