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
    public partial class cartcs : Form
    {
        public static cartcs instance = default !;
        public ListBox lb;
        public cartcs()
        {
            InitializeComponent();
            instance = this;
            lb = listBox1;
        }

        private void cartcs_Load(object sender, EventArgs e)
        {
            foreach (string ss in Form1.instance.lb.Items)
            {
                lb.Items.Add(ss);
            }
            
            label2.Text = Form1.instance.lll.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Form1.instance.lb.Items.Clear();
            Form1.instance.x = 0;
            Form1.instance.bt.Text = "Shopping Cart";
            label2.Text = "Rp 0";
            Form1.instance.Total = 0;
        }
    }
}
