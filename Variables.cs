using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Morales
{
    public class Variables
    {
        public static void FirstCase (string password, string username, string [] ints, int Case1WRU, string StrPrice, string[] Tipid, int[] AStock, string[] TipidMenu, 
            string[] Student, int[] BStock, string[] StudentMenu, string[] Super, int[] CStock, string[] SuperMenu, string[] Drinks, int[] DStock, string[] DrinkMenu, 
            string[] Dessert, int[] EStock, string[] DessertMenu, int[] Stock, string[] Option, string[] Menu, string order, int OptionIndex, double TotalSales, string Transact)
        {
            string[] Case1 = { "Check Stock", "Check Sales", "Exit" };

            Console.Clear();
            Console.WriteLine("Login for Confirmation ");
            Console.WriteLine();
            Console.Write("Username :   ");
            string Uname = Console.ReadLine().ToLower();
            Console.Write("Password :   ");
            string Pword = Console.ReadLine().ToLower();

            if (Pword == password && Uname == username)
            {
                Console.Clear();
                Console.WriteLine("Welcome Boss!!!");
                Console.WriteLine();
                do
                {
                    for (int i = 0; i < Case1.Length; i++)
                    {
                        Console.WriteLine(ints[i].ToString().PadRight(5) + Case1[i].PadRight(25));
                    }
                    Console.Write("What do you want :");
                    Case1WRU = Convert.ToInt32(Console.ReadLine());

                    if (Case1WRU > 0 && Case1WRU < 4)
                    {
                        switch (Case1WRU)
                        {
                            case 1:
                                PrintStock.TipidStock(StrPrice, Tipid, AStock, TipidMenu);
                                PrintStock.StudentStock(StrPrice, Student, BStock, StudentMenu);
                                PrintStock.SuperStock(StrPrice, Super, CStock, SuperMenu);
                                PrintStock.DrinkStock(StrPrice, Drinks, DStock, DrinkMenu);
                                PrintStock.DessertStock(StrPrice, Dessert, EStock, DessertMenu);

                                Console.WriteLine();

                                Console.Write("Do you want to add stock (Y/N)?");
                                string Yn = Console.ReadLine().ToUpper();
                                //Adding stock
                                if (Yn == "Y")
                                {
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Adding Stocks".PadLeft(30));
                                        Console.WriteLine();
                                        Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(25));
                                        for (int i = 0; i < Option.Length; i++)
                                        {
                                            Console.WriteLine(Option[i].ToString().PadRight(8) + Menu[i].ToString().PadRight(25));
                                        }
                                        Console.Write("Enter Code : ");
                                        order = Console.ReadLine().ToUpper();
                                        OptionIndex = Array.IndexOf(Option, order);

                                        Console.Clear();

                                        if (OptionIndex < 0)
                                        {
                                            Console.WriteLine("INVALID CODE!!!");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            switch (OptionIndex)
                                            {
                                                case 0:
                                                    AddingStock.TipidAddStock(Tipid, AStock, TipidMenu, Stock);
                                                    break;
                                                case 1:
                                                    AddingStock.StudentAddStock(Student, BStock, StudentMenu, Stock);
                                                    break;
                                                case 2:
                                                    AddingStock.SuperAddStock(Super, CStock, SuperMenu, Stock);
                                                    break;
                                                case 3:
                                                    AddingStock.DrinkAddStock(Drinks, DStock, DrinkMenu, Stock);
                                                    break;
                                                case 4:
                                                    AddingStock.DessertAddStock(Dessert, EStock, DessertMenu, Stock);
                                                    break; ;
                                            }
                                        }
                                    } while (order != "F");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Total Sales".PadLeft(25));

                                Console.WriteLine($"{TotalSales.ToString("#,0.00")}".PadLeft(23));

                                break;
                            case 3:
                                Console.WriteLine();
                                break;
                        }
                    }
                    do
                    {
                        Console.Write("Wanna continue managing the store (Y/N) : ");
                        Transact = Console.ReadLine().ToUpper();

                    } while (Transact != "Y" && Transact != "N");

                    Console.Clear();
                } while (Transact != "N");

            }
            else Console.WriteLine("Login Failed");
        }
       
    }
}
