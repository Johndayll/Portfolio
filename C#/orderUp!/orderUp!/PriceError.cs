using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderUp_
{
    public partial class PriceError : Form
    {
      
        public PriceError()
        {
            InitializeComponent();
            bunifuFormFadeTransition1.ShowAsyc(this);
        }


          private void FoodQuantity_Load(object sender, EventArgs e)
        {
          
        }


        public  void Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
         
          
        }

        private void bunifuFormFadeTransition2_TransitionEnd(object sender, EventArgs e)
        {
       
        }
    }
}
