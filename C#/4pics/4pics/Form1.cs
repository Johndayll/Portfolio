using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4pics
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Label choice = (Label)sender;
            bool canClick = (label11.Text == string.Empty || label12.Text != string.Empty || label13.Text == string.Empty || label14.Text == string.Empty);
            if (canClick)
            {
                for (int i = 0; i < 4; i++)
                {
                    var box = Controls.Find($"label{i + 11}", false).First() as Label;
                    if(box.Text == string.Empty)
                    {
                        choice.Hide();
                        box.BackColor = choice.BackColor;
                        box.Text = choice.Text;
                        break;
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text != string.Empty)
            {
                for (int i = 0; i < 10; i++) {
                    var text = Controls.Find($"c{i + 1}", false).First() as Label;
                    if (label.Text == text.Text)
                    {
                        text.Show();
                        label.Text = string.Empty;
                        label.BackColor = Color.SeaShell;
         
                    }
                        }
            }
        }
       private void label14_changed(object sender, EventArgs e)
        {
            string finalWord = label11.Text + label12.Text + label13.Text + label14.Text;
            if (finalWord.Length == 4)
            {
                if (finalWord == "BRED")
                {
                    MessageBox.Show("NICE", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not nice", "YOU LOSE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void mouse_hover(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Size = new Size(135, 128);
            picture.BringToFront();
        }

        private void mouse_leave(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Size = new Size(105, 98);
            picture.SendToBack();

        }
    }
}





