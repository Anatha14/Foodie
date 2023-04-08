using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anathapindika_Gautama_Putra_UAS1
{
    public partial class MilkTea : Form
    {
        public static MilkTea instance = default!;
        public Label lb;
        public TextBox tb1;
        public MilkTea()
        {
            InitializeComponent();
            instance = this;
            lb = label20;
            tb1 = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int jumlah = int.Parse(textBox1.Text);
            jumlah -= 1;
            textBox1.Text = jumlah.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int jumlah = int.Parse(textBox1.Text);
            jumlah += 1;
            textBox1.Text = jumlah.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string jumlah = textBox1.Text;

            string Ukuran, Ice, Rasa, Jelly, Pearl, Coconut, Mix;

            if (radioButton1.Checked == true)
            {
                Ukuran = radioButton1.Text;
            }
            else if (radioButton6.Checked == true)
            {
                Ukuran = radioButton6.Text;
            }
            else
            {
                Ukuran = radioButton2.Text;
            }

            if (radioButton7.Checked == true)
            {
                Ice = radioButton7.Text;
            }
            else if (radioButton8.Checked == true)
            {
                Ice = radioButton8.Text;
            }
            else if (radioButton9.Checked == true)
            {
                Ice = radioButton9.Text;
            }
            else
            {
                Ice = radioButton10.Text;
            }

            if (radioButton3.Checked == true)
            {
                Rasa = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                Rasa = radioButton4.Text;
            }
            else
            {
                Rasa = radioButton5.Text;
            }


            if (checkBox1.Checked == true)
            {
                Jelly = checkBox1.Text;
            }
            else
            {
                Jelly = "";
            }
            if (checkBox2.Checked == true)
            {
                Pearl = checkBox2.Text;
            }
            else
            {
                Pearl = "";
            }
            if (checkBox3.Checked == true)
            {
                Coconut = checkBox3.Text;
            }
            else
            {
                Coconut = "";
            }
            if (checkBox4.Checked == true)
            {
                Mix = checkBox4.Text;
            }
            else
            {
                Mix = "";
            }

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
                {
                    if (Jelly == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milk Tea", Ukuran, Ice, Rasa, Pearl, Coconut, Mix));
                    }
                    else if (Pearl == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milk Tea", Ukuran, Ice, Rasa, Jelly, Coconut, Mix));
                    }
                    else if (Coconut == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milk Tea", Ukuran, Ice, Rasa, Jelly, Pearl, Mix));
                    }
                    else if (Mix == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milk Tea", Ukuran, Ice, Rasa, Jelly, Pearl, Coconut));
                    }
                    else
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7} \n\t {8}",
                         DateTime.Now.ToString(), jumlah + "x Milk Tea", Ukuran, Ice, Rasa, Jelly, Pearl, Coconut, Mix));
                    }
                }
                else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false)
                {
                    Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \tTanpa Topping Tambahan",
                        DateTime.Now.ToString(), jumlah + "x Milk Tea", Ukuran, Ice,Rasa));
                }

                Form1.instance.tm.Enabled = true;

                this.Close();
            }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int harga = 25000;
            int jumlah = Convert.ToInt16(textBox1.Text);
            if (radioButton2.Checked == true)
            {
                harga = harga + 5000;
            }
            else if (radioButton6.Checked == true)
            {
                harga = harga + 10000;
            }

            if (radioButton4.Checked == true)
            {
                harga = harga + 7000;
            }
            else if (radioButton5.Checked == true)
            {
                harga = harga + 9000;
            }

            if (checkBox1.Checked == true)
            {
                harga = harga + 5000;
            }

            if (checkBox2.Checked == true)
            {
                harga = harga + 8000;
            }

            if (checkBox3.Checked == true)
            {
                harga = harga + 9000;
            }
            if (checkBox4.Checked == true)
            {
                harga = harga + 10000;
            }

            if (textBox1.Text == "1")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

            harga = harga * jumlah;

            label20.Text = harga.ToString();

            label10.Text = "Rp " + harga;
        }
    }
}
