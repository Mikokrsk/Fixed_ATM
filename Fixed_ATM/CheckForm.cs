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
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        public void PrintCheсk(List<Banknote> banknotes)
        {
            checkListBox.Items.Clear();
            checkListBox.Items.Add("\tCheck\n");
            checkListBox.Items.Add("Banknote\tnum\t\tsum");
            banknotes.Reverse();
            int totalSum = 0;
            foreach (var banknote in banknotes)
            {
                if (banknote.number >= 1)
                {
                    checkListBox.Items.Add($"{banknote.cost}\t{banknote.number}\t=\t{banknote.GetSum()}");
                    totalSum += banknote.GetSum();
                }
            }
            checkListBox.Items.Add($"Total = {totalSum}");
        }
    }
}
