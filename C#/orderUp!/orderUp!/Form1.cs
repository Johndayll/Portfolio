using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using BunifuAnimatorNS;
namespace orderUp_
{
    public partial class Form1 : Form
    {
        double price;
       
        public Form1()
        {
            InitializeComponent();
            FoodList.Columns[0].ReadOnly = true;
            FoodList.Columns[2].ReadOnly = true;
        }
        private void Crab_Click(object sender, EventArgs e)
        {
            Total.Enabled = true;
            PayButton.Enabled = true;
            int quantity = 1;  
            BunifuTileButton Clicked = (BunifuTileButton)sender;
            int Length = bunifuToolTip1.GetToolTipTitle(Clicked).Length;
            int IndexOfPrice = bunifuToolTip1.GetToolTipTitle(Clicked).IndexOf("@");
            price = double.Parse(bunifuToolTip1.GetToolTipTitle(Clicked).Substring((IndexOfPrice + 1), (Length - IndexOfPrice) - 1));
            price = quantity * price;
            FoodList.Rows.Add(Clicked.LabelText, quantity, price);

            bunifuTransition1.HideSync(Clicked, false, BunifuAnimatorNS.Animation.VertSlide);
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FoodList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (FoodList.CurrentCell != null)
            {

                int row = FoodList.CurrentCell.RowIndex;
                int column = FoodList.CurrentCell.ColumnIndex;
                int quantity = Convert.ToInt32(FoodList.CurrentCell.Value);
                if (quantity <= 0)
                {
                    quantity = 1;
                    FoodList.CurrentCell.Value = quantity;
                }
                FoodList[column + 1, row].Value = quantity * price;


                
            }
            double sum = 0;
            for (int i = 0; i < FoodList.RowCount; i++)
            {

                sum += Convert.ToDouble(FoodList[2, i].Value);
                Total.Text = $"{sum:00}";
            }

        }
        private void FoodList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < FoodList.RowCount; i++)
            {
                
                sum += Convert.ToDouble(FoodList[2, i].Value);
                Total.Text = $"{sum:00}";
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            Total.Text = String.Empty;
            Total.ReadOnly = false;
            double sum = 0;
            for (int i = 0; i < FoodList.RowCount; i++)
            {
                sum += Convert.ToDouble(FoodList[2, i].Value);
            }
            Total.PlaceholderText = $"Enter amount of cash to pay {sum} bells!";
            PayButton.Enabled = false;
            ChangeButton.Enabled = true;
            FoodList.Enabled = false;
            //Disabling buttons
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.Find($"b{i}", false).First() as BunifuTileButton;
                button.Enabled = false;
            }
            }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                NextButton.Enabled = true;
                ChangeButton.Enabled = false;
                double payment = Convert.ToDouble(Total.Text);
                double sum = 0;
                for (int i = 0; i < FoodList.RowCount; i++)
                {
                    sum += Convert.ToDouble(FoodList[2, i].Value);
                }

                if(payment < sum)
                {
                    PriceError Invalid = new PriceError();
                    NextButton.Enabled = false;
                    Invalid.ShowDialog();
                    Total.Text = String.Empty;
                    Total.PlaceholderText = $"Enter amount of cash to pay {sum} bells!";
                    ChangeButton.Enabled = true;
                }
                else
                {
                    ChangeButton.Enabled = false;
                    Total.Text = $"Your change is {payment - sum:00} bells!";
                }
               
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FoodList.Rows.Clear();
            Total.Text = String.Empty;
            Total.PlaceholderText = "Total";
            ChangeButton.Enabled = false;
            NextButton.Enabled = false;
            FoodList.Enabled = true;
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.Find($"b{i}", false).First() as BunifuTileButton;
                button.Enabled = true;
                if (!button.Visible)
                {
                    bunifuTransition1.ShowSync(button, false, BunifuAnimatorNS.Animation.VertSlide);
                }
            }
        }

        private void Total_TextChange(object sender, EventArgs e)
        {

        }

        private void FoodList_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (FoodList.RowCount == 2)
            {
                PayButton.Enabled = false;
            }
            double sum = 0;
            for (int i = 0; i < FoodList.RowCount; i++)
            {
                sum += Convert.ToDouble(FoodList[2, i].Value);
                Total.Text = $"{sum:00}";
            }
        }

        private void FoodList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int row = FoodList.CurrentCell.RowIndex;

           string Food = FoodList[0, row].Value.ToString();
           
            for(int i = 1; i <=10; i++)
            {
                var button = Controls.Find($"b{i}", false).First() as BunifuTileButton;
                if (Food == button.LabelText)
                {
                    bunifuTransition1.ShowSync(button, false, BunifuAnimatorNS.Animation.VertSlide);
                }
            }
        }

        private void FoodList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (FoodList.CurrentCell != null)
            {
              
                int row = FoodList.CurrentCell.RowIndex;
                int column = FoodList.CurrentCell.ColumnIndex;
                int quantity = Convert.ToInt32(FoodList.CurrentCell.Value);
                if (quantity <= 0)
                {
                    quantity = 1;
                    FoodList.CurrentCell.Value = quantity;
                }
                FoodList[column + 1, row].Value = quantity * price;
                FoodList.CommitEdit(DataGridViewDataErrorContexts.Commit);


            }
            double sum = 0;
            for (int i = 0; i < FoodList.RowCount; i++)
            {

                sum += Convert.ToDouble(FoodList[2, i].Value);
                Total.Text = $"{sum:00}";
            }
        }
    } 
}
