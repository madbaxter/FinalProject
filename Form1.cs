namespace finalproject
    // Madeline Baxter -- final project :)
    // 7/17: Increment 1 estimation: 2 hours
    // 7/17: Increment 1 - total time worked: 2 hours
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // 7/17: shows what form user is currently on
            // using just during incrmental phases -- will remove for final build
        }
    }
}