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
    public partial class MieGoreng : Form
    {
        public static MieGoreng instance = default!;
        
        public TextBox tb1;
        public Label lb;
        
        public MieGoreng()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            lb = label20;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int harga = 48000;
            int jumlah = Convert.ToInt16(textBox1.Text);
            if (radioButton2.Checked == true)
            {
                harga = harga + 12000;
            }

            if (radioButton4.Checked == true)
            {
                harga = harga + 8000;
            }
            else if (radioButton5.Checked == true)
            {
                harga = harga + 20000;
            }

            if (checkBox1.Checked == true)
            {
                harga = harga + 5000;
            }

            if (checkBox2.Checked == true)
            {
                harga = harga + 7000;
            }

            if (checkBox3.Checked == true)
            {
                harga = harga + 9000;
            }
            if (checkBox4.Checked == true)
            {
                harga = harga + 20000;
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

        private void MieGoreng_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            string jumlah = textBox1.Text;
            string porsi, toping, telurmata, telurdadar, sosisgoreng,sosisbakar;

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
                    telurmata = checkBox1.Text;
                }
                else
                {
                    telurmata = "";
                }
                if (checkBox2.Checked == true)
                {
                    telurdadar = checkBox2.Text;
                }
                else
                {
                    telurdadar = "";
                }
                if (checkBox3.Checked == true)
                {
                    sosisgoreng = checkBox3.Text;
                }
                else
                {
                    sosisgoreng = "";
                }
                if (checkBox4.Checked == true)
                {
                    sosisbakar = checkBox4.Text;
                }
                else
                {
                    sosisbakar = "";
                }
           
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
                {
                    if (telurmata == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} ",
                            DateTime.Now.ToString(), jumlah + "x Mie Goreng", porsi, toping, telurdadar, sosisgoreng, sosisbakar));
                    }
                    else if (telurdadar == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} ",
                            DateTime.Now.ToString(), jumlah + "x Mie Goreng", porsi, toping, telurmata, sosisgoreng, sosisbakar));
                    }
                    else if (sosisgoreng == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} ",
                            DateTime.Now.ToString(), jumlah + "x Mie Goreng", porsi, toping, telurmata, telurdadar, sosisbakar));
                    }
                    else if (sosisbakar == "")
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} ",
                            DateTime.Now.ToString(), jumlah + "x Mie Goreng", porsi, toping, telurmata, telurdadar, sosisgoreng));
                    }
                    else
                    {
                        Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \n\t {4} \n\t {5} \n\t {6} \n\t {7}",
                            DateTime.Now.ToString(), jumlah + "x Mie Goreng", porsi, toping, telurmata, telurdadar, sosisgoreng, sosisbakar));
                    }

                }
                else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false & checkBox4.Checked == false)
                {
                    Form1.instance.lb.Items.Add(string.Format("{0} \n\t{1} \n\t {2} \n\t {3} \tTanpa Topping Tambahan",
                        DateTime.Now.ToString(), jumlah + "x Mie Goreng", porsi, toping));
                }
                
                
                
                Form1.instance.tm.Enabled = true;
                this.Close();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
