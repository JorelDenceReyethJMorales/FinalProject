using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Morales
{
    internal class Case2
    {
        public static void case1(string[] Tipid, int[] AStock, string[] TipidMenu, double[] APrice, string order,
            int OptionIndex,string StrQty, int Qty)
        {
            
                Console.Write("Enter Code : ");
                order = Console.ReadLine().ToUpper();
                OptionIndex = Array.IndexOf(Tipid, order);
                if (OptionIndex < 0)
                {
                    Console.WriteLine("INVALID CODE!!!");
                }
                else
                {
                    if (order != "A6")
                    {
                        do
                        {
                            do
                            {
                                Console.Write("Enter Qty : ");
                                StrQty = Console.ReadLine();

                                if (int.TryParse(StrQty, out Qty) == false)
                                {
                                    Console.WriteLine("Invalid quantity value!!!");
                                }
                                else
                                {
                                    if (AStock[OptionIndex] >= Qty)
                                    {
                                        Console.WriteLine();
                                    }
                                    else { Console.WriteLine($"We apologize, but we're currently low on stock and only have {AStock[OptionIndex]} of that item available. (Type 0 to Reset Order) "); }
                                }
                            } while ((AStock[OptionIndex] < Qty));

                        }
                        while (int.TryParse(StrQty, out Qty) == false);
                    }
                }
        }
    }
}
