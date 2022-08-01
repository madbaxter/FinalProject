using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnForm01_Click(object sender, EventArgs e)
        {
            // Launch Main Menu Form
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Launch Adopt form
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // creating the string objects that hold the input from the donation form
            string name, phone, email, amt, paymode;
            name = textBox1.Text;
            phone = textBox2.Text;
            email = textBox3.Text;
            paymode = domainUpDown1.ToString(); // pulls payment type from collection
            // create if/else statement to pull donation amouny from the radio box selected
            if (radioButton1.Checked == true)
                amt = radioButton1.Text;
            else if (radioButton2.Checked == true)
                amt = radioButton2.Text;
            else if (radioButton3.Checked == true)
                amt = radioButton3.Text;
            else if (radioButton4.Checked == true)
                amt = radioButton4.Text;
            else amt = radioButton5.Text; // ends loop
            //create message box to print after entering info
            MessageBox.Show("Thank you, " + name + " for your donation of " + amt + ". It is greatly appreciated! A receipt will be emailed to you shortly!");
        }
    }
}
