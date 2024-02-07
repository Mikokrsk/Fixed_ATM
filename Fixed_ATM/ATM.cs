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
            foreach (var banknote in _banknotes)
            {
                if (banknote.cost == cost)
                {
                    banknote.number += number;
                    break;
                }
            }
        }
        public static bool WithdrawCash(int sum)
        {
            if (sum <= GetTotalSumCost())
            {
                List<Banknote> withdrawnMoney = new List<Banknote>();

                for (int i = _banknotes.Count - 1; i >= 0; i--)
                {
                    var num = sum / _banknotes[i].cost;
                    if (num >= 1)
                    {
                        if (_banknotes[i].number > num)
                        {
                            sum -= _banknotes[i].cost * num;
                        }
                        else
                        {
                            num = _banknotes[i].number;
                            sum -= _banknotes[i].cost * num;
                        }
                        withdrawnMoney.Add(new Banknote(_banknotes[i].cost, num));
                    }
                    else
                    {
                        withdrawnMoney.Add(new Banknote(_banknotes[i].cost, 0));
                    }
                }

                if (sum != 0)
                {
                    Console.WriteLine("Залишок = " + sum);
                    return false;
                }
                else
                {
                    withdrawnMoney.Reverse();
                    for (int i = _banknotes.Count - 1; i >= 0; i--)
                    {
                        _banknotes[i].number -= withdrawnMoney[i].number;
                    }
                    CheckForm checkForm = new CheckForm();
                    checkForm.PrintCheсk(withdrawnMoney);
                    checkForm.ShowDialog();
                   
                    return true;
                }
            }
            else
            {
                return false;
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
        public static void StartFillList()
        {
            CreateNewBanknote(1, 0);
            CreateNewBanknote(2, 0);
            CreateNewBanknote(5, 0);
            CreateNewBanknote(10, 0);
            CreateNewBanknote(20, 0);
            CreateNewBanknote(50, 0);
            CreateNewBanknote(100, 0);
            CreateNewBanknote(200, 0);
            CreateNewBanknote(500, 0);
            CreateNewBanknote(1000, 0);
        }
        private static void CreateNewBanknote(int cost, int number)
        {
            var newBanknote = new Banknote(cost, number);
            _banknotes.Add(newBanknote);
        }

        /*private static void GetCheсk(List<Banknote> banknotes)
        {
            Console.WriteLine("Check");
            foreach (var banknote in banknotes)
            {
                Console.WriteLine($"{banknote.cost} X {banknote.number}");
            }
        }*/
    }
}
