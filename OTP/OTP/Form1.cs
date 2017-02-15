using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void enctryptBtn_Click(object sender, EventArgs e)
        {
            string unEncryptText, //hold unencryted text from nonEncrytTextBox
            encrytText; //hold encryted text

            unEncryptText = nonEncryptTextBox.Text; //assign text in nonEncrytTextBox to unEncryptText
            List<char> unEncrytedChar = unEncryptText.ToCharArray().ToList(); //assign unEncryptText to a character array

            /*
             * call method here for encytion from the encrytion class
             */

            List<int> key = new List<int>(); //holds the incoming list of ints from the encryption method
        }

        private void nonEncryptTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing letters and white space
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
