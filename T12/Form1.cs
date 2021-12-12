using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label[] L = new Label[100];
        Panel[] P = new Panel[100];
        int c = 0;
        Bitmap b1;
        bool add = false;
        private void ClickA(object sender, EventArgs e)
        {
            if (add)
            {
                P[c] = new Panel();
                L[c] = new Label();
                L[c].Size = new Size(100, 50);
                L[c].Text = "Click Here";
                L[c].Location = new Point(2, 2);
                L[c].BackColor = Color.White;
                L[c].Font = new Font("Arial", 10, FontStyle.Bold);
                L[c].MouseDown += Form1_MouseDown;
                L[c].MouseUp += Form1_MouseUp;
                L[c].MouseMove += Form1_MouseMove;
                L[c].Click += Form1_Click;
                L[c].BackColor = Color.White;
                L[c].Name = c + " false c0";
                P[c].Size = new Size(L[c].Width + 4, L[c].Height + 4);
                P[c].Name = "Click Here";
                P[c].Location = new Point((MousePosition.X - this.Left) - 50, (MousePosition.Y - this.Top - 27) - 25);
                P[c].BackColor = Color.Black;
                P[c].Controls.Add(L[c]);
                this.Controls.Add(P[c]);
                P[c++].BringToFront();
                add = false;
                this.Cursor = Cursors.Default;
            }
            if (sender is Label)
            {
                Label l = sender as Label;
                if (l.Text == "+")
                {
                    add = true;
                    this.Cursor = Cursors.Cross;
                }
                else
                    if (l.Name == "btngi")
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Image |*.png;*.jpg";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        b1 = new Bitmap(ofd.FileName);
                        Bitmap b2 = new Bitmap(b1, b1.Width / 3, b1.Height / 3);
                        pictureBox1.Width = b1.Width / 3;
                        pictureBox1.Height = b1.Height / 3;
                        pi.Width = (b1.Width / 3) + 4;
                        pi.Height = (b1.Height / 3) + 4;
                        btngi.Top = pi.Top + pi.Height + 10;
                        btns.Top = pi.Top + pi.Height + 10;
                        pictureBox1.Image = b2;
                    }
                }
                else
                    if (l.Name == "btns")
                {
                    Bitmap bitmap = new Bitmap(b1);
                    Graphics g = Graphics.FromImage(bitmap);
                    for (int i = 0; i < c; i++)
                    {
                        if ((P[i].Left) >= pi.Left + 2 && (P[i].Top) >= pi.Top + 2)
                        {
                            SolidBrush drawBrush = new SolidBrush(L[i].ForeColor);
                            var fnt = new Font(L[i].Font.FontFamily, L[i].Font.Size * 3, FontStyle.Bold);
                            int dy = (int)fnt.GetHeight(g) * 1, y2 = (P[i].Top - (pi.Top + 2)) * 3;
                            for (int j = 0; j < P[i].Name.Split(new string[] { "&nl;" }, StringSplitOptions.None).Length; j++)
                            {
                                g.DrawString(P[i].Name.Split(new string[] { "&nl;" }, StringSplitOptions.None)[j], fnt, drawBrush, new Point((P[i].Left - (pi.Left + 2)) * 3, y2));
                                y2 += dy + 10;
                            }
                        }
                    }
                    SaveFileDialog ofd = new SaveFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        bitmap.Save(ofd.FileName);
                    }
                    bitmap.Dispose();
                    g.Dispose();
                }
                else
                {
                    ColorDialog color = new ColorDialog();
                    if (color.ShowDialog() == DialogResult.OK)
                    {
                        labelcolor.BackColor = color.Color;
                        for (int i = 0; i < c; i++)
                        {
                            if (L[i].Name.Contains("c1"))
                            {
                                L[i].ForeColor = color.Color;
                            }
                        }
                    }
                }
            }
            else
                if (sender is Form)
            {
                for (int i = 0; i < c; i++)
                {
                    L[i].Name = L[i].Name.Replace("c1", "c0").Replace("true", "false");
                    L[i].BackColor = Color.White;
                }
            }
        }
        int x, y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Label)
            {
                Label l = sender as Label;
                for (int i = 0; i < c; i++)
                {
                    if (L[i].Name != l.Name)
                    {
                        L[i].Name = L[i].Name.Replace("c1", "c0").Replace("true", "false");
                        L[i].BackColor = Color.White;
                    }
                }
                l.Name = l.Name.Replace("false", "true");
                l.Cursor = Cursors.SizeAll;
                x = e.X;
                y = e.Y;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Label)
            {
                Label l = sender as Label;
                l.Name = l.Name.Replace("true", "false");
                l.Cursor = Cursors.Default;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Label)
            {
                Label l = sender as Label;
                if (l.Name.Contains("true"))
                {
                    l.BringToFront();
                    P[Convert.ToInt32(l.Name.Split(' ')[0])].Location = new Point((MousePosition.X - this.Left - x), (MousePosition.Y - this.Top - y - 27));
                }
            }
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label l = sender as Label;
                for (int i = 0; i < c; i++)
                {
                    if (L[i].Name != l.Name)
                        L[i].Name = L[i].Name.Replace("c1", "c0").Replace("true", "false");
                }
                if (l.Name.Contains("c1"))
                {
                    l.Name = l.Name.Replace("c1", "c0");
                    l.BackColor = Color.White;
                }
                else
                {
                    l.Name = l.Name.Replace("c0", "c1");
                    l.BackColor = Color.Green;
                    this.Focus();
                }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < c; i++)
            {
                if (L[i].Name.Contains("c1"))
                {
                    L[i].Font = new Font(comboBox1.Text, ((TrackBar)sender).Value, FontStyle.Bold);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFont = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFont.Families;
            for (int i = 0; i < fontFamilies.Length; i++)
            {
                comboBox1.Items.Add(fontFamilies[i].Name);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < c; i++)
            {
                if (L[i].Name.Contains("c1"))
                    L[i].Font = new Font(comboBox1.Text, L[i].Font.Size, L[i].Font.Style);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((MousePosition.X - this.Left) >= t.Left && (MousePosition.X - this.Left) <= (t.Left + t.Width) && (MousePosition.Y - this.Top) >= t.Top && (MousePosition.Y - this.Top) <= (t.Top + t.Height))
            {
                for (int i = 0; i < t.Controls.Count; i++)
                {
                    t.Controls[i].Enabled = true;
                }
            }
            else
                for (int i = 0; i < t.Controls.Count; i++)
                {
                    t.Controls[i].Enabled = false;
                }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox txt = sender as TextBox;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (txt.Name == "textboxw")
                    {
                        for (int i = 0; i < c; i++)
                        {
                            if (L[i].Name.Contains("c1"))
                            {
                                try
                                {
                                    L[i].Width = Convert.ToInt32(txt.Text);
                                    P[i].Width = L[i].Width + 4;
                                }
                                catch { MessageBox.Show("Please enter only digits", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                            }
                        }
                    }
                    else
                        if (txt.Name == "textboxh")
                    {
                        for (int i = 0; i < c; i++)
                        {
                            if (L[i].Name.Contains("c1"))
                            {
                                try
                                {
                                    L[i].Height = Convert.ToInt32(txt.Text);
                                    P[i].Height = L[i].Height + 4;
                                }
                                catch { MessageBox.Show("Please enter only digits", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < c; i++)
                {
                    if (L[i].Name.Contains("c1"))
                    {
                        if (L[i].Text != "" && e.KeyChar == Convert.ToChar(Keys.Back))
                        {
                            L[i].Text = L[i].Text.Remove(L[i].Text.Length - 1);
                            if (P[i].Name.Length > 5 && P[i].Name.Substring(P[i].Name.Length - 4) == "&nl;")
                            {
                                P[i].Name = P[i].Name.Remove(P[i].Name.Length - 4, 4);
                                P[i].Name = P[i].Name.Remove(P[i].Name.Length - 1);
                            }
                            else
                                P[i].Name = P[i].Name.Remove(P[i].Name.Length - 1);
                        }
                        else
                            if (e.KeyChar != Convert.ToChar(Keys.Back))
                        {
                            L[i].Text += e.KeyChar;
                            P[i].Name += e.KeyChar;
                        }

                        if (e.KeyChar == (char)13) P[i].Name += "&nl;";

                    }
                }
            }
        }

    }
}
