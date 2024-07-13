using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Morales
{
    public class PrintStock
    {
        public static void TipidStock(string StrPrice, string[] Tipid, int[] AStock, string[] TipidMenu)
        {

            Console.Clear();
            Console.WriteLine("Checking Stocks".PadLeft(30));
            Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(30) + "Stock".PadRight(10));

            for (int i = 0; i < Tipid.Length - 1; i++)
            {
                if (AStock[i] >= 0) { StrPrice = AStock[i].ToString(); }
                else { StrPrice = ""; }
                Console.WriteLine(Tipid[i].PadRight(8) + TipidMenu[i].PadRight(30) + StrPrice.PadRight(10));
            }          
        }
        public static void StudentStock(string StrPrice, string[] Student, int[] BStock, string[] StudentMenu)
        {

            Console.WriteLine();
            for (int i = 0; i < Student.Length - 1; i++)
            {
                if (BStock[i] >= 0) { StrPrice = BStock[i].ToString(); }
                else { StrPrice = ""; }
                Console.WriteLine(Student[i].PadRight(8) + StudentMenu[i].PadRight(30) + StrPrice.PadRight(10));
            }
        }
        public static void SuperStock(string StrPrice, string[] Super, int[] CStock, string[] SuperMenu)
        {

            Console.WriteLine();
            for (int i = 0; i < Super.Length - 1; i++)
            {
                if (CStock[i] >= 0) { StrPrice = CStock[i].ToString(); }
                else { StrPrice = ""; }
                Console.WriteLine(Super[i].PadRight(8) + SuperMenu[i].PadRight(30) + StrPrice.PadRight(10));
            }
        }
        public static void DrinkStock(string StrPrice, string[] Drinks, int[] DStock, string[] DrinkMenu)
        {

            Console.WriteLine();
            for (int i = 0; i < Drinks.Length - 1; i++)
            {
                if (DStock[i] >= 0) { StrPrice = DStock[i].ToString(); }
                else { StrPrice = ""; }
                Console.WriteLine(Drinks[i].PadRight(8) + DrinkMenu[i].PadRight(30) + StrPrice.PadRight(10));
            }
        }
        public static void DessertStock(string StrPrice, string[] Dessert, int[] EStock, string[] DessertMenu)
        {

            Console.WriteLine();
            for (int i = 0; i < Dessert.Length - 1; i++)
            {
                if (EStock[i] >= 0) { StrPrice = EStock[i].ToString(); }
                else { StrPrice = ""; }
                Console.WriteLine(Dessert[i].PadRight(8) + DessertMenu[i].PadRight(30) + StrPrice.PadRight(10));
            }
        }
        public static void OptionList(string[] Option, string[] Menu)
        {

            Console.WriteLine();
            Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(25));
            for (int i = 0; i < Option.Length; i++)
            {
                Console.WriteLine(Option[i].PadRight(8) + Menu[i].PadRight(25));
            }
        }
    }
}
