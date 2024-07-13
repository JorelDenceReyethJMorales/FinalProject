using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Morales
{
    public class AddingStock
    {
        public static void TipidAddStock(string[] Tipid, int[] AStock, string[] TipidMenu , int[] Stock)
        {  
            string StrAstock = "";
            for(int i = 0; i < Tipid.Length - 1; i++) 
            {
                do
                {
                    Console.Write($"{Tipid[i].PadRight(8)}  {TipidMenu[i].PadRight(30)} : ");
                    StrAstock = Console.ReadLine();

                    if (int.TryParse(StrAstock, out Stock[i]) == false)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    if (i < 5)
                    {
                       Console.WriteLine();
                    }
                } while (int.TryParse(StrAstock, out Stock[i]) == false);
                AStock[i] = AStock[i] + Stock[i];
            } 
                Console.WriteLine();
        }
        public static void StudentAddStock( string[] Student, int[] BStock, string[] StudentMenu, int[] Stock)
        {
            string StrAstock = "";
            for (int i = 0; i < Student.Length - 1; i++)
            {   do
                {
                    Console.Write($"{Student[i].PadRight(8)}  {StudentMenu[i].PadRight(30)} : ");
                    StrAstock = Console.ReadLine();

                    if (int.TryParse(StrAstock, out Stock[i]) == false)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    if (i < 5)
                    {
                        Console.WriteLine();
                    }
                } while (int.TryParse(StrAstock, out Stock[i]) == false) ;
                BStock[i] = BStock[i] + Stock[i];

            }

            Console.WriteLine();
        }
        public static void SuperAddStock( string[] Super, int[] CStock, string[] SuperMenu, int[] Stock)
        {
            string StrAstock = "";
            for (int i = 0; i < Super.Length - 1; i++)
            {
                do
                {
                    Console.Write($"{Super[i].PadRight(8)}  {SuperMenu[i].PadRight(30)} : ");
                    StrAstock = Console.ReadLine();

                    if (int.TryParse(StrAstock, out Stock[i]) == false)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    if (i < 5)
                    {
                        Console.WriteLine();
                    }
                } while (int.TryParse(StrAstock, out Stock[i]) == false) ;
                CStock[i] = CStock[i] + Stock[i];
            }

            Console.WriteLine();
        }
        public static void DrinkAddStock( string[] Drinks, int[] DStock, string[] DrinkMenu, int[] Stock)
        {
            string StrAstock = "";
            for (int i = 0; i < Drinks.Length - 1; i++)
            { 
                do
                    {
                        Console.Write($"{Drinks[i].PadRight(8)}  {DrinkMenu[i].PadRight(30)} : ");
                    StrAstock = Console.ReadLine();

                    if (int.TryParse(StrAstock, out Stock[i]) == false)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    if (i < 5)
                    {
                        Console.WriteLine();
                    }
                } while (int.TryParse(StrAstock, out Stock[i]) == false) ;
                DStock[i] = DStock[i] + Stock[i];
            }

            Console.WriteLine();
        }
        public static void DessertAddStock( string[] Dessert, int[] EStock, string[] DessertMenu, int[] Stock)
        {
            string StrAstock = "";
            for (int i = 0; i < Dessert.Length - 1; i++)
            {
                do
                {
                    Console.Write($"{Dessert[i].PadRight(8)}  {DessertMenu[i].PadRight(30)} : ");
                    StrAstock = Console.ReadLine();

                    if (int.TryParse(StrAstock, out Stock[i]) == false)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    if (i < 5)
                    {
                        Console.WriteLine();
                    }
                } while (int.TryParse(StrAstock, out Stock[i]) == false) ;
                EStock[i] = EStock[i] + Stock[i];
            }
            Console.WriteLine();
        }

    }
}
