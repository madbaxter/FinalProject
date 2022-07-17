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
        string textFile = "animals.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnForm01_Click(object sender, EventArgs e)
        {
            // read and write to file example

            
            
            // Back to Main Menu
            Form1 form1 = new Form1(); // goes to main menu
            form1.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // breed selection
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // age range selection properties
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // select sex of the dog
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Shows Available Animal for Adoption
            // load photo of dog available and info about them
            // include bio for animal -- future 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            // Loads Foster form
            Form1 form1 = new Form1(); // goes to main menu
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Loads Donate form
            Form1 form1 = new Form1(); // goes to main menu
            form1.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // input that is written in textBox1 is written to file
            // sets it up as a stream writer
            using (var writer = new StreamWriter(@"animals.txt"))
                writer.Write(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // sets it up as a stream reader
            //user is able to read from the file
            string[] lines = File.ReadAllLines(textFile);
            using (StreamReader file = new StreamReader(textFile))
                foreach (string line in lines) // goes to top of file and grabs the first line
                {
                    MessageBox.Show(line); // shows what was in that file
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // 
            for (int i = 0; i < 5; i++)
            {
                // shows random number generated
                //imit to generate the Random number within the specified range from 10 to 20
                MessageBox.Show(Convert.ToString(rnd.Next(10, 20))); 

            }
        }
    }
}
