namespace My_new_item_add
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashbord ds = new Dashbord("Guset");
            ds.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Sashika" && textBox2.Text == "Dilshan")
            {
                Dashbord ab = new Dashbord("Admin");
                button1.FlatStyle=FlatStyle.Flat;
                button1.FlatAppearance.BorderColor=Color.DarkOrange;
                button1.FlatAppearance.BorderSize = 10;
                

                ab.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}