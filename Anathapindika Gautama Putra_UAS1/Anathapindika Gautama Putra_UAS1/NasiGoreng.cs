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
    public partial class NasiGoreng : Form
    {
        public static NasiGoreng instance = default!;
        public Label lb;
        public TextBox tb1;
        
       
        public NasiGoreng()
        {
            InitializeComponent();
            instance = this;
            lb = label20;
            tb1 = textBox1;
                        
        }

        private void NasiGoreng_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int harga = 50000;
            int jumlah = Convert.ToInt16(textBox1.Text);
            if (radioButton2.Checked==true)
            {
                harga = harga + 10000;
            }
            
            if (radioButton4.Checked==true)
            {
                harga = harga + 3000;
            }
            else if (radioButton5.Checked==true)
            {
                harga = harga + 6000;
            }

            if (checkBox1.Checked==true)
            {
                harga = harga + 5000 ;
            }

            if (checkBox2.Checked==true)
            {
                harga = harga + 5000;
            }

            if (checkBox3.Checked==true)
            {
                harga = harga + 15000;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int jumlah = int.Parse(textBox1.Text);
            jumlah += 1;
            textBox1.Text = jumlah.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jumlah = int.Parse(textBox1.Text);
            jumlah -= 1;
            textBox1.Text = jumlah.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string jumlah = textBox1.Text;
            
            string porsi, toping, telur, sosis, kulit;

                if (radioButton1.Checked == true)
                {
                    porsi = radioButton1.Text;
                }
                else
                {
                    porsi = radioButton2.Text;
                }

                if (radioButton3.Checked == true)
                {
                    toping = radioButton3.Text;
                }
                else if (radioButton4.Checked == true)
                {
                    toping = radioButton4.Text;
                }
                else
                {
                    toping = radioButton5.Text;
                }
                if (checkBox1.Checked == true)
                {
                    telur = checkBox1.Text;
                }
                else
                {
                    telur = "";
                }
                if (checkBox2.Checked == true)
                {
                    sosis = checkBox2.Text;
                }
                else
                {
                    sosis = "";
                }
                if (checkBox3.Checked == true)
                {
                    kulit = checkBox3.Text;
                }
                else
                {
                    kulit = "";
                }
            
                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
                {
                    if (telur == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5}",
                            DateTime.Now.ToString(), jumlah + "x Nasi Goreng", porsi, toping, sosis, kulit));
                    }
                    else if (sosis == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5}",
                            DateTime.Now.ToString(), jumlah + "x Nasi Goreng", porsi, toping, telur, kulit));
                    }
                    else if (kulit == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5}",
                            DateTime.Now.ToString(), jumlah + "x Nasi Goreng", porsi, toping, telur, sosis));
                    }
                    else
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6}",
                         DateTime.Now.ToString(), jumlah + "x Nasi Goreng", porsi, toping, telur, sosis, kulit));
                    }
                }
                else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false)
                {
                    Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \tTanpa Topping Tambahan",
                        DateTime.Now.ToString(), jumlah + "x Nasi Goreng", porsi, toping));
                }

                Form1.instance.tm.Enabled = true;

                this.Close();
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
