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
    public partial class Milkshake : Form
    {
        public static Milkshake instance = default!;
        public Label lb;
        public TextBox tb1;
        public Milkshake()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            lb = label20;
        }

        private void Milkshake_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                harga = harga + 5000;
            }
            else if (radioButton5.Checked == true)
            {
                harga = harga + 8000;
            }

            if (checkBox1.Checked == true)
            {
                harga = harga + 2000;
            }

            if (checkBox2.Checked == true)
            {
                harga = harga + 2500;
            }

            if (checkBox3.Checked == true)
            {
                harga = harga + 4000;
            }
            if (checkBox4.Checked == true)
            {
                harga = harga + 5000;
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string jumlah = textBox1.Text;

            string Ukuran, Rasa, IceCream, Saus, Meses, Oreo, Cherry;

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
                Rasa = radioButton7.Text;
            }
            else if (radioButton8.Checked == true)
            {
                Rasa = radioButton8.Text;
            }
            else if (radioButton9.Checked == true)
            {
                Rasa = radioButton9.Text;
            }
            else
            {
                Rasa = radioButton10.Text;
            }

            if (radioButton3.Checked == true)
            {
                IceCream = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                IceCream = radioButton4.Text;
            }
            else
            {
                IceCream = radioButton5.Text;
            }


            if (checkBox1.Checked == true)
            {
                Saus = checkBox1.Text;
            }
            else
            {
                Saus = "";
            }
            if (checkBox2.Checked == true)
            {
                Meses = checkBox2.Text;
            }
            else
            {
                Meses = "";
            }
            if (checkBox3.Checked == true)
            {
                Oreo = checkBox3.Text;
            }
            else
            {
                Oreo = "";
            }
            if (checkBox4.Checked == true)
            {
                Cherry = checkBox4.Text;
            }
            else
            {
                Cherry = "";
            }
            
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
                {
                    if (Saus == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milkshake", Ukuran, Rasa, IceCream, Meses, Oreo, Cherry));
                    }
                    else if (Meses == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milkshake", Ukuran, Rasa, IceCream, Saus, Oreo, Cherry));
                    }
                    else if (Oreo == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milkshake", Ukuran, Rasa, IceCream, Saus, Meses, Cherry));
                    }
                    else if (Cherry == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Milkshake", Ukuran, Rasa, IceCream, Saus, Meses, Oreo));
                    }
                    else
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7} \n\t {8}",
                         DateTime.Now.ToString(), jumlah + "x Milkshake", Ukuran, Rasa, IceCream, Saus, Meses, Oreo, Cherry));
                    }
                }
                else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false)
                {
                    Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \tTanpa Topping Tambahan",
                        DateTime.Now.ToString(), jumlah + "x Milkshake", Ukuran, Rasa, IceCream));
                }

                Form1.instance.tm.Enabled = true;

                this.Close();
            
        }
    }
}
