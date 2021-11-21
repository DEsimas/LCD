using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCD
{
    public partial class LCD : Form
    {
        private int n1, n2, d1, d2, a1 = -1, a2 = -1;
        private bool ch = true;

        private void button3_Click(object sender, EventArgs e)
        {
            if (ch)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                ch = false;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                ch = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            d1 = 0;
            d2 = 0;
            a1 = -1;
            a2 = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Focus();
        }

        private void LCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
            else if (e.KeyCode == Keys.Delete)
                button2.PerformClick();
        }

        public LCD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
                d1 = Convert.ToInt32(textBox2.Text);
                n2 = Convert.ToInt32(textBox3.Text);
                d2 = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода");
            }
            if (d1 == 0 || d2 == 0)
            {
                MessageBox.Show("Деление на ноль");
            }
            else
            {
                for (int a = 1; a < d2 + 1; a++)
                {
                    for (int b = 1; b < d1 + 1; b++)
                    {
                        if (d1 * a == d2 * b)
                        {
                            a1 = a;
                            a2 = b;
                            break;
                        }
                    }
                    if (a1 != -1 && a2 != -1)
                    {
                        break;
                    }
                }
                textBox5.Text = Convert.ToString(n1 * a1);
                textBox6.Text = Convert.ToString(d1 * a1);
                textBox7.Text = Convert.ToString(n2 * a2);
                textBox8.Text = Convert.ToString(d2 * a2);
            }
        }
    }
}