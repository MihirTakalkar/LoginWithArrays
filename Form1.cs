using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mihirs30thLoginArrays
{
    public partial class Form1 : Form
    {
        //create a string array of usernames check
        //and another string array for their passwords check
        //on the form create a username and password textbox and a login button check
        //when the button is pressed check the arrays for a user corresponding to what's currently in the textboxes
        string[] usernames = { "jon", "jack", "jimmy" };
        string[] passwords = { "cat", "fish", "dog" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flip = false;
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == textBox1.Text && passwords[i] == textBox2.Text)
                {
                    MessageBox.Show("Welcome");
                    flip = true;
                }

            }

            if (flip == false)
            {
                //login fail
                MessageBox.Show("Wrong Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newUser = textBox1.Text;
            string[] temp = new string[usernames.Length + 1];
            for (int i = 0; i < usernames.Length; i++)
            {
                temp[i] = usernames[i];
            }
            temp[temp.Length - 1] = newUser;
            usernames = temp;

            string newPass = textBox2.Text;
            string[] ok = new string[passwords.Length + 1];
            for (int i = 0; i < passwords.Length; i++)
            {
                ok[i] = passwords[i];
            }
            ok[ok.Length - 1] = newPass;
            passwords = ok;

        }
    }
}
