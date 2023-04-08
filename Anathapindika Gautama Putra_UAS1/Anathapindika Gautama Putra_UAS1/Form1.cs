namespace Anathapindika_Gautama_Putra_UAS1
{
    public partial class Form1 : Form
    {

        public static Form1 instance = default !;
        public System.Windows.Forms.Timer tm;
        public ListBox lb;
        public int x, y;
        public double Total=0, Harga;
        public Button bt;
        public Label lll;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tm = timer1;
            lb = listBox1;
            bt = button5;
            lll = label14; 
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = "1";
            NasiGoreng ng = new NasiGoreng();
            ng.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = "2";
            MieGoreng mg = new MieGoreng(); 
            mg.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = "3";
            MilkTea mt = new MilkTea();
            mt.ShowDialog();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text = "4";
            Milkshake ms = new Milkshake();
            ms.ShowDialog();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (label11.Text == "1")
            {
                y = int.Parse(NasiGoreng.instance.tb1.Text);
                Harga = int.Parse(NasiGoreng.instance.lb.Text);
            }
            else if (label11.Text == "2")
            {
                y = int.Parse(MieGoreng.instance.tb1.Text);
                Harga = int.Parse(MieGoreng.instance.lb.Text);
            }
            else if (label11.Text=="3")
            {
                y = int.Parse(MilkTea.instance.tb1.Text);
                Harga = int.Parse(MilkTea.instance.lb.Text);
            }
            else if (label11.Text=="4")
            {
                y = int.Parse(Milkshake.instance.tb1.Text);
                Harga = int.Parse(Milkshake.instance.lb.Text);
            }

            x = x + y;
            Total = Total + Harga;
            label14.Text = "Rp" + Total.ToString();

            button5.Text = "Shopping Cart (" + x + ")";
            timer1.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cartcs cs = new cartcs();
            cs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label14.Text = "Rp" + Total.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cartcs cs = new cartcs();
            cs.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cartcs cs = new cartcs();
            cs.ShowDialog();
        }
    }
}