using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fixed_ATM
{
    public partial class Form1 : Form
    {
        public List<Label> numbersLabels = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ATM.StartFillList();
            ATM.LoadCash(1, 2);
            ATM.LoadCash(2, 5);
            ATM.LoadCash(5, 2);
            ATM.LoadCash(20, 5);
            ATM.LoadCash(100, 10);
            ATM.LoadCash(500, 1);
            ATM.LoadCash(1000, 1);
            PrintTottalCost();
            numbersLabels.Clear();
            numbersLabels.AddRange(new Label[] {
                label_money_1,
                label_money_2,
                label_money_5,
                label_money_10,
                label_money_20,
                label_money_50,
                label_money_100,
                label_money_200,
                label_money_500,
                label_money_1000,
            });
            PrintCost();
        }
        private void withdrawMoneyButton_Click(object sender, EventArgs e)
        {
            var withdrawCash = Int32.Parse(withdrawMoneyTextBox.Text);
            if (ATM.WithdrawCash(withdrawCash))
            {
                PrintCost();
                PrintTottalCost();
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private void PrintTottalCost()
        {
            TotalCostLabel.Text = $"TotalCost : {ATM.GetTotalSumCost()}";
        }
        private void PrintCost()
        {
            var bancnotes = ATM.GetBancnotes();
            for (int i = 0; i < bancnotes.Count; i++)
            {
                numbersLabels[i].Text = $"X {bancnotes[i].number}";
            }
        }

        private void loadCashButton_Click(object sender, EventArgs e)
        {
            var cost = Int32.Parse(costTextBox.Text); 
            var num = Int32.Parse(numTextBox.Text);
            ATM.LoadCash(cost,num);
            PrintCost();
            PrintTottalCost();
        }
    }
}