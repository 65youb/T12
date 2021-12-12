namespace T12
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.t = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelcolor = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textboxh = new System.Windows.Forms.TextBox();
            this.textboxw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Label();
            this.pi = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btngi = new System.Windows.Forms.Label();
            this.btns = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.t.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.pi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Controls.Add(this.panel2);
            this.t.Controls.Add(this.trackBar1);
            this.t.Controls.Add(this.comboBox1);
            this.t.Controls.Add(this.textboxh);
            this.t.Controls.Add(this.textboxw);
            this.t.Controls.Add(this.label6);
            this.t.Controls.Add(this.label5);
            this.t.Controls.Add(this.label4);
            this.t.Controls.Add(this.label3);
            this.t.Controls.Add(this.label2);
            this.t.Controls.Add(this.btnadd);
            this.t.Location = new System.Drawing.Point(13, 13);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(405, 413);
            this.t.TabIndex = 0;
            this.t.Click += new System.EventHandler(this.ClickA);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.labelcolor);
            this.panel2.Location = new System.Drawing.Point(201, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 24);
            this.panel2.TabIndex = 10;
            // 
            // labelcolor
            // 
            this.labelcolor.BackColor = System.Drawing.Color.Black;
            this.labelcolor.Location = new System.Drawing.Point(2, 2);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(20, 20);
            this.labelcolor.TabIndex = 1;
            this.labelcolor.Click += new System.EventHandler(this.ClickA);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 227);
            this.trackBar1.Maximum = 90;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(353, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Arial";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textboxh
            // 
            this.textboxh.Location = new System.Drawing.Point(201, 100);
            this.textboxh.Name = "textboxh";
            this.textboxh.Size = new System.Drawing.Size(164, 20);
            this.textboxh.TabIndex = 7;
            this.textboxh.Text = "50";
            this.textboxh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // textboxw
            // 
            this.textboxw.Location = new System.Drawing.Point(201, 58);
            this.textboxw.Name = "textboxw";
            this.textboxw.Size = new System.Drawing.Size(164, 20);
            this.textboxw.TabIndex = 6;
            this.textboxw.Text = "100";
            this.textboxw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Font Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Font Family";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(3, 9);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(25, 25);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "+";
            this.btnadd.Click += new System.EventHandler(this.ClickA);
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.Color.Black;
            this.pi.Controls.Add(this.pictureBox1);
            this.pi.Location = new System.Drawing.Point(498, 13);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(332, 232);
            this.pi.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 228);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ClickA);
            // 
            // btngi
            // 
            this.btngi.AutoSize = true;
            this.btngi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngi.Location = new System.Drawing.Point(495, 260);
            this.btngi.Name = "btngi";
            this.btngi.Size = new System.Drawing.Size(111, 25);
            this.btngi.TabIndex = 11;
            this.btngi.Text = "Get Image";
            this.btngi.Click += new System.EventHandler(this.ClickA);
            // 
            // btns
            // 
            this.btns.AutoSize = true;
            this.btns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btns.Location = new System.Drawing.Point(633, 260);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(62, 25);
            this.btns.TabIndex = 12;
            this.btns.Text = "Save";
            this.btns.Click += new System.EventHandler(this.ClickA);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.btns);
            this.Controls.Add(this.btngi);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.t);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "T 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.ClickA);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.t.ResumeLayout(false);
            this.t.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.pi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel t;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelcolor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textboxh;
        private System.Windows.Forms.TextBox textboxw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnadd;
        private System.Windows.Forms.Panel pi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btngi;
        private System.Windows.Forms.Label btns;
        private System.Windows.Forms.Timer timer1;
    }
}

