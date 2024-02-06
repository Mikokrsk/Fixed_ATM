using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Fixed_ATM
{
    public static class ATM
    {
        private static List<Banknote> _banknotes = new List<Banknote>();

        public static void LoadCash(int cost, int number)
        {
            var banknote = new Banknote(cost, number);
            _banknotes.Add(banknote);
        }
        public static List<Banknote> WithdrawCash(int sum)
        {
            if (sum <= GetTotalSumCost())
            {
                List<Banknote> withdrawnMoney = new List<Banknote>();

                for (int i = _banknotes.Count - 1; i >= 0; i--)
                {
                    var num = sum / _banknotes[i].cost;
                    if (num >= 1)
                    {
                        if (_banknotes[i].number >= num)
                        {
                            sum -= _banknotes[i].cost * num;
                            _banknotes[i].number -= num;
                            withdrawnMoney.Add(new Banknote(_banknotes[i].cost, num));
                        }
                        else
                        {
                            num = _banknotes[i].number;
                            sum -= _banknotes[i].cost * num;
                            _banknotes[i].number = 0;
                            withdrawnMoney.Add(new Banknote(_banknotes[i].cost, num));
                        }
                    }
                    else
                    {
                        withdrawnMoney.Add(new Banknote(_banknotes[i].cost, 0));
                    }
                }
                Console.WriteLine("Залишок = " + sum);
                return withdrawnMoney;
            }
            else
            {
                return null;
            }
        }
        public static int GetTotalSumCost()
        {
            int total = 0;
            foreach (Banknote banknote in _banknotes)
            {
                total += banknote.GetSum();
            }
            return total;
        }
        public static List<Banknote> GetBancnotes()
        {
            return _banknotes;
        }
    }
}
