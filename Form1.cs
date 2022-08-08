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
            // Adopt form
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Create Donate Form to launch when pressing button
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); //hides form after launching new form
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // add Volunteer form
           
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide(); //hides form after launching new form
        }
    }
}