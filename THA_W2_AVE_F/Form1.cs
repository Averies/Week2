using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W2_AVE_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int a =Convert.ToInt32(textBox_Age.Text);
            
            if (a<18)
            {
                string below = "Name: " + textBox_Name.Text + ", Email: " + 
                    textBox_Email.Text + ", Phone Number: " + textBox_PhoneNumber.Text;
                MessageBox.Show(below, "You are a minor", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else 
            {
                string greater = "Name: " + textBox_Name.Text + ", Email: " + 
                    textBox_Email.Text + ", Phone Number: " + textBox_PhoneNumber.Text;
                MessageBox.Show(greater, "You are an adult", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Age.Clear();
            textBox_Email.Clear();
            textBox_PhoneNumber.Clear();
        }
    }
}
