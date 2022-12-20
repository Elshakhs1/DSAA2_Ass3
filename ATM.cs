using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAA2_Ass3
{
    internal class ATM
    {
        public List<int> moneyList { get; set; }
        public ATM()
        {
            moneyList = new List<int>();
            moneyList.Add(0);
            moneyList.Add(1);
            moneyList.Add(2);
            moneyList.Add(5);
            moneyList.Add(10);
            moneyList.Add(20);
            moneyList.Add(50);
            moneyList.Add(100);
            moneyList.Add(200);
        }

        public void printAllOptions(double requestedAmount, int maxAmountOfCoins, int startingIndex)
        {
            int maxMoney = moneyList[moneyList.Count - 1] * maxAmountOfCoins;
            List<int> options = new List<int>();
            bool finish = false;
            bool alreadyIteratedFirstIndex = false;

            int[] calculationArr = new int[maxAmountOfCoins];
            int[] resultArr = new int[maxAmountOfCoins];
            for (int i = 0; i < calculationArr.Length; i++)
            {
                calculationArr[i] = 0;
                resultArr[i] = 0;
            }

            while (finish == false)
            {
                alreadyIteratedFirstIndex = false;

                resultArr[0] = moneyList[calculationArr[0]];

                // the result
                {

                    if (resultArr.Sum() == requestedAmount)
                    {
                        int checkCurrentSum = 0;
                        foreach (var item in resultArr)
                        {
                            if (item != 0) checkCurrentSum++;
                        }
                        if (options.Contains(checkCurrentSum))
                        {

                        }
                        else
                        {
                            options.Add(checkCurrentSum);
                            Console.WriteLine();
                            foreach (var item in resultArr)
                            {
                                if (item != 0)
                                {
                                    Console.Write($"{item}, ");
                                }
                            }
                        }

                    }
                }

                if (calculationArr[0] == moneyList.Count - 1)
                {
                    bool nextNumberMustChange = false;
                    alreadyIteratedFirstIndex = true;
                    calculationArr[0] = 0;

                    for (int i = 1; i < calculationArr.Length; i++)
                    {
                        if (calculationArr[i] == moneyList.Count - 1)
                        {
                            nextNumberMustChange = true;
                            calculationArr[i] = 0;
                            continue;
                        }

                        if (nextNumberMustChange)
                        {
                            if (calculationArr[i] == moneyList.Count - 1)
                            {
                                calculationArr[i] = 0;
                            }
                            else
                            {
                                calculationArr[i]++;
                                resultArr[i] = moneyList[calculationArr[i]];
                                nextNumberMustChange = false;
                                break;
                            }
                        }
                        else
                        {
                            calculationArr[i]++;
                            resultArr[i] = moneyList[calculationArr[i]];
                            break;
                        }

                        resultArr[i] = moneyList[calculationArr[i]];
                    }
                    if (resultArr.Sum() == maxMoney)
                    {
                        finish = true;
                    };
                }

                if (alreadyIteratedFirstIndex == false)
                {
                    calculationArr[0]++;
                };
            }
        }
    }
}