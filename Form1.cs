using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                PasswordGenerator(6);
            }
            else if(checkBox2.Checked)
            {
                PasswordGenerator(10);
            }
            else if (checkBox3.Checked)
            {
                PasswordGenerator(12);
            }
            else
            {
                PasswordGenerator(8);
            }
            
        }
        public void PasswordGenerator(int len)
        {
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);

            }
            textBox1.Text = result.ToString();
        }

    }
}
