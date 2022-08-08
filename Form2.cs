using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// Madeline Baxter -- final project :)
// 7/17: Increment 1 estimation: 2 hours
// 7/17: Increment 1 - total time worked: 2 hours

namespace finalproject
{
    public partial class Form2 : Form
    {
      
        string[] array = { "Jax - Tabby", "King - Short Hair", "Melly - Siamese" };
        // string cats = string.Join("\n", array);
        string[] array2 = { "Bo-Mix", "Tom-Pitbull", "Jax-Husky Mix" };
        // string dogs = string.Join ("\n", array2);
  
        
        public Form2()
        {
            InitializeComponent();
        }

        private void btnForm01_Click(object sender, EventArgs e)
        {

            // Back to Main Menu
            Form1 form1 = new Form1(); // goes to main menu
            form1.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            // Adoption Search Box:
            // Placeholder for future functionality
            // groupbox will be for entering properties ot search for available dogs
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Loads Donate form
            Form3 form3 = new Form3(); // goes to donate form
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Loads volunteer form
            Form4 form4 = new Form4(); // goes to volunteer form
            form4.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string cats = string.Join("\n", array);
            MessageBox.Show(cats);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dogs = string.Join("\n", array2);
            MessageBox.Show(dogs);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}