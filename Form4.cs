using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Madeline Baxter - MS539
// Final Project V3 
// Time stimated: 2 hours
// Time to completion - 2.5 hours 


namespace finalproject
{
    public partial class Form4 : Form
    {
        class Volunteer
        {
            // create private attributes
            private string fullName;
            private string phoneNumber;
            private string emailAddress;

            // create constructer
            public Volunteer(string fname, string phone, string email) // set as public so the user can create classes
            {
                fullName = fname;
                phoneNumber = phone;
                emailAddress = email;
            }
            public void display()
            {
                MessageBox.Show("Thank you " + fullName + " for submitting your volunteer form! We will reach out to you in 2-5 business days!");
            }
        }

        class Large : Volunteer
        {
            private string groupNum;

            public Large(string fname, string phone, string email, string group) : base(fname, phone, email)
            {
                groupNum = group;
            }
            public void displayLarge()
            {
                MessageBox.Show("Thank you for submmitting a group volunteer form for a party of " + groupNum + " we will reach out in 2-5 business days!");
            }
        }
    
        public Form4()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Volunteer v1 = new Volunteer(textBox7.Text, textBox8.Text, textBox9.Text);
            v1.display();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Large l1 = new Large(textBox10.Text, textBox11.Text, textBox12.Text, domainUpDown2.Text);
            l1.display();
        }
    }
}
