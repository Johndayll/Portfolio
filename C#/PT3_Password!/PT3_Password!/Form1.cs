using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT3_Password_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (PassWordBox.Text.Length > 0)
            {
                string password = PassWordBox.Text;
                char firstChar = password[0];
                char lastChar = password[password.Length - 1];
                bool length = false, digit = false, character = false, restriction = false;

                //First Condition
                if (password.Length > 1 && password.Length < 8)
                {
                    length = true;
                    Length.Text = "✔️";
                }
                else
                {
                    length = false;
                    Length.Text = "❌";
                }
                //Second Condition
                if (length)
                {
                    if (char.IsUpper(firstChar) && char.IsLower(lastChar)) 
                    {
                        character = true;
                        Character.Text = "✔️";
                    }
                    else
                    {
                        character = false;
                        Character.Text = "❌";
                    }
                }
                //Third Condition
                if (password.Length > 2)
                {
                    for (int i = 1; i < password.Length - 1; i++)
                    {
                        if (char.IsDigit(password[i]))
                        {
                            digit = true;
                            Digit.Text = "✔️";
                            break;
                        }
                        else
                        {
                            digit = false;
                            Digit.Text = "❌";
                        }
                    }
                }
                else
                {
                    digit = false;
                    Digit.Text = "❌";
                }

                //Fourth Condition
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsLetterOrDigit(password[i]))
                    {
                        restriction = true;
                        Restriction.Text = "✔️";
                    }
                    else
                    {
                        restriction = false;
                        Restriction.Text = "❌";
                        break;
                    }
                }
           


                //Final Condition
                if(restriction && character && digit && length)
                {
                    Validity.Text = "Valid!";
                    Validity.ForeColor = Color.Green;

                }
                else
                {
                    Validity.Text = "Invalid!";
                    Validity.ForeColor = Color.Red;
                }

            }
            else
            {
                Restriction.Text = "❌";
                Digit.Text = "❌";
                Character.Text = "❌";
                Length.Text = "❌";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PassWordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
