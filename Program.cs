using System.Collections;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Transactions;

namespace FinalProject_Morales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] Option = { "A", "B", "C", "D", "E", "F" };
            string[] Menu = { "Normal Meal",
                              "Student Meal",
                              "Super Meal",
                              "Drinks",
                              "Side dish/Dessert",
                              "End of transaction "};
            string[] strings = { "Manage Store", "To Order", "Exit" };
            string[] ints = { "1", "2" , "3" };
            string Transact = "";
            string StrPrice = "";
           
            string username = "jorel";
            string password = "jorel123";
            string exit = "exit";
            int WRU;
            int Case1WRU= 0;
            string addStock = "";
            string AddStockSection ="";
            int StockIndex;


            List<string> OrderList = new List<string>();
            string order = "";
            int Qty = 0;
            double SubTotal = 0;
            double TotalPrice = 0;
            double TotalSales = 0;
            double SubTotalPrice = 0;
            string StrQty = "";
            int OptionIndex = 0 ;
            int CurrentOrderList = 0;


            int[] Stock = { 0, 0, 0, 0, 0 };

            //Tipid Meal Variables
            string[] Tipid = { "A1", "A2", "A3", "A4", "A5", "A6" };
            string[] TipidMenu = { "1pc FriedChicken with Rice",
                                                       "2pc FriedChicken with Rice",
                                                       "1pc Burger Steak with Rice",
                                                       "2pc Burger Steak with Rice",
                                                       "A1 and A3 Combo",
                                                       "Back to Menu"};
            double[] APrice = { 99.75, 149.75, 75.99, 135.99, 167.29, 0.00 };
            int[] AStock = { 0, 0, 0, 0, 0 };

            //Student Meal Variables
            Console.Clear();
            string[] Student = { "B1", "B2", "B3", "B4", "B5", "B6" };
            string[] StudentMenu = { "4pc  Siomai with Rice",
                                                         "8pc  Siomai with Rice",
                                                         "4pc Shanghai with Rice",
                                                         "8pc Shanghai with Rice",
                                                         "B1 and B3 Combo",
                                                         "Back to Menu"};
            double[] BPrice = { 25.99, 35.75, 45.82, 66.93, 52.12, 0.00 };
            int[] BStock = { 0, 0, 0, 0, 0 };

            //Super Meal Variables
            string[] Super = { "C1", "C2", "C3", "C4", "C5", "C6" };
            string[] SuperMenu = { "Ultimate Burger Steak",
                                                       "FChiken, BSteak, Shanghai ",
                                                       "FChiken, BSteak, siomai ",
                                                       "FChiken, Burger, Shanghai ",
                                                       "FChiken, Burger, Siomai ",
                                                       "Back to Menu"};
            double[] CPrice = { 235.55, 190.92, 190.92, 186.91, 186.91, 0.00 };
            int[] CStock = { 0, 0, 0, 0, 0 };

            //Drinks Variable
            string[] Drinks = { "D1", "D2", "D3", "D4", "D5", "D6" };
            string[] DrinkMenu = { "Regular Coke",
                                                         "Diet Coke",
                                                         "Coke Float",
                                                         "Iced Coffee",
                                                         "Icead Coffee Float",
                                                         "Back to Menu"};
            double[] DPrice = { 45.00, 45.00, 65.00, 55.00, 75.00, 0.00 };
            int[] DStock = { 0, 0, 0, 0, 0 };

            //Dessert/Snacks Variables
            string[] Dessert = { "E1", "E2", "E3", "E4", "E5", "E6" };
            string[] DessertMenu = { "Regular Fries",
                                                         "Large Fries",
                                                         "Jumbo Fries",
                                                         "Regular Sundae",
                                                         "Peach Mango Pie",
                                                         "Back to Menu"};
            double[] EPrice = { 45.00, 65.00, 45.00, 85.00, 52.00, 0.00 };
            int[] EStock = { 0, 0, 0, 0, 0 };

            do
            {
                OrderList.Clear();
                Console.Clear();
                SubTotalPrice = 0; //Clearing the SubtotalPrice
                Console.WriteLine("Lantakan Fast food".PadLeft(25));
                for (int i = 0; i < strings.Length; i++)
                {
                    Console.WriteLine(ints[i].PadRight(5) + strings[i].PadRight(25));
                }
                Console.WriteLine();
                Console.Write("What do you want :");
                 WRU = Convert.ToInt32(Console.ReadLine());
                
                switch (WRU)
                {

                    case 1:
                        Variables.FirstCase(password,username,ints,Case1WRU,StrPrice,Tipid,AStock,TipidMenu,
                            Student,BStock,StudentMenu,Super,CStock,SuperMenu,Drinks,DStock,DrinkMenu,
                            Dessert,EStock,DessertMenu,Stock,Option,Menu,order,OptionIndex,TotalSales,Transact);
                        
                        break;
                    case 2:
                        Console.Clear();

                        do
                        {
                            Console.WriteLine("Lantakan Fast food".PadLeft(25));
                            PrintStock.OptionList(Option, Menu);    
                            Console.WriteLine();

                            // Order
                            do
                            {
                                Console.Write("Enter Code : ");
                                order = Console.ReadLine().ToUpper();
                                OptionIndex = Array.IndexOf(Option, order);
                                if (OptionIndex < 0)
                                {
                                    Console.WriteLine("INVALID CODE!!!");
                                }
                                else
                                {

                                    switch (OptionIndex)
                                    {
                                        case 0:
                                            Console.Clear();
                                            

                                            Console.WriteLine("Lantakan Fast food".PadLeft(25));
                                            Console.WriteLine();
                                            Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(30) + "Price".PadRight(10));
                                            for (int i = 0; i < Tipid.Length; i++)
                                            {
                                                if (APrice[i] > 0) { StrPrice = APrice[i].ToString(); }
                                                else { StrPrice = ""; }

                                                Console.WriteLine(Tipid[i].PadRight(8) + TipidMenu[i].PadRight(30) + StrPrice.PadRight(10));
                                            }
                                            do
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
                                                        AStock[OptionIndex] = AStock[OptionIndex] - Qty;
                                                        SubTotal = APrice[OptionIndex] * Qty;
                                                        SubTotalPrice = SubTotalPrice + SubTotal;
                                                        TotalPrice = SubTotalPrice;
                                                        OrderList.Add(order.PadRight(8) + TipidMenu[OptionIndex].PadRight(25) +
                                                                                        APrice[OptionIndex].ToString().PadLeft(9) +
                                                                                        Qty.ToString().PadLeft(10) + SubTotal.ToString("#,0.00").PadLeft(12));
                                                    }
                                                }

                                            } while (order != "A6");
                                            Console.Clear();
                                            PrintStock.OptionList(Option, Menu);

                                            break;
                                        case 1:
                                            Console.Clear();
                                            Console.WriteLine("Lantakan Fast food".PadLeft(25));
                                            Console.WriteLine();
                                            Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(30) + "Price".PadRight(10));
                                            for (int i = 0; i < Student.Length; i++)
                                            {
                                                if (BPrice[i] > 0) { StrPrice = BPrice[i].ToString(); }
                                                else { StrPrice = ""; }

                                                Console.WriteLine(Student[i].PadRight(8) + StudentMenu[i].PadRight(30) + StrPrice.PadRight(10));
                                            }
                                            do
                                            {
                                                Console.Write("Enter Code : ");
                                                order = Console.ReadLine().ToUpper();
                                                OptionIndex = Array.IndexOf(Student, order);
                                                if (OptionIndex < 0)
                                                {
                                                    Console.WriteLine("INVALID CODE!!!");
                                                }
                                                else
                                                {
                                                    if (order != "B6")
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
                                                                    if (BStock[OptionIndex] >= Qty)
                                                                    {
                                                                        Console.WriteLine();
                                                                    }
                                                                    else { Console.WriteLine($"We apologize, but we're currently low on stock and only have {BStock[OptionIndex]} of that item available. (Type 0 to Reset Order) "); }
                                                                }
                                                            } while ((BStock[OptionIndex] < Qty));
                                                        }
                                                        while (int.TryParse(StrQty, out Qty) == false);

                                                        SubTotal = BPrice[OptionIndex] * Qty;
                                                        SubTotalPrice = SubTotalPrice + SubTotal;
                                                        TotalPrice = SubTotalPrice;
                                                        OrderList.Add(order.PadRight(8) + StudentMenu[OptionIndex].PadRight(25) +
                                                                                        BPrice[OptionIndex].ToString().PadLeft(10) +
                                                                                        Qty.ToString().PadLeft(10) + SubTotal.ToString("#,0.00").PadLeft(12));
                                                    }
                                                }

                                            } while (order != "B6");
                                            Console.Clear();
                                            PrintStock.OptionList(Option, Menu);
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("Lantakan Fast food".PadLeft(25));
                                            Console.WriteLine();
                                            Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(30) + "Price".PadRight(10));
                                            for (int i = 0; i < Super.Length; i++)
                                            {
                                                if (CPrice[i] > 0) { StrPrice = CPrice[i].ToString(); }
                                                else { StrPrice = ""; }

                                                Console.WriteLine(Super[i].PadRight(8) + SuperMenu[i].PadRight(30) + StrPrice.PadRight(10));
                                            }
                                            do
                                            {
                                                Console.Write("Enter Code : ");
                                                order = Console.ReadLine().ToUpper();
                                                OptionIndex = Array.IndexOf(Super, order);
                                                if (OptionIndex < 0)
                                                {
                                                    Console.WriteLine("INVALID CODE!!!");
                                                }
                                                else
                                                {
                                                    if (order != "C6")
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
                                                                    if (CStock[OptionIndex] >= Qty)
                                                                    {
                                                                        Console.WriteLine();
                                                                    }
                                                                    else { Console.WriteLine($"We apologize, but we're currently low on stock and only have {CStock[OptionIndex]} of that item available. (Type 0 to Reset Order) "); }
                                                                }
                                                            } while ((CStock[OptionIndex] < Qty));
                                                        }
                                                        while (int.TryParse(StrQty, out Qty) == false);

                                                        SubTotal = CPrice[OptionIndex] * Qty;
                                                        SubTotalPrice = SubTotalPrice + SubTotal;
                                                        TotalPrice = SubTotalPrice;
                                                        OrderList.Add(order.PadRight(8) + SuperMenu[OptionIndex].PadRight(25) +
                                                                                        CPrice[OptionIndex].ToString().PadLeft(10) +
                                                                                        Qty.ToString().PadLeft(10) + SubTotal.ToString("#,0.00").PadLeft(12));
                                                    }
                                                }

                                            } while (order != "C6");
                                            Console.Clear();
                                            PrintStock.OptionList(Option, Menu);
                                            break;
                                        case 3:
                                            Console.Clear();                                        
                                            Console.WriteLine("Lantakan Fast food".PadLeft(25));
                                            Console.WriteLine();
                                            Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(30) + "Price".PadRight(10));
                                            for (int i = 0; i < Drinks.Length; i++)
                                            {
                                                if (DPrice[i] > 0) { StrPrice = DPrice[i].ToString(); }
                                                else { StrPrice = ""; }

                                                Console.WriteLine(Drinks[i].PadRight(8) + DrinkMenu[i].PadRight(30) + StrPrice.PadRight(10));
                                            }
                                            do
                                            {
                                                Console.Write("Enter Code : ");
                                                order = Console.ReadLine().ToUpper();
                                                OptionIndex = Array.IndexOf(Drinks, order);
                                                if (OptionIndex < 0)
                                                {
                                                    Console.WriteLine("INVALID CODE!!!");
                                                }
                                                else
                                                {
                                                    if (order != "D6")
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
                                                                    if (DStock[OptionIndex] >= Qty)
                                                                    {
                                                                        Console.WriteLine();
                                                                    }
                                                                    else { Console.WriteLine($"We apologize, but we're currently low on stock and only have {DStock[OptionIndex]} of that item available. (Type 0 to Reset Order) "); }
                                                                }
                                                            } while ((DStock[OptionIndex] < Qty));
                                                        }
                                                        while (int.TryParse(StrQty, out Qty) == false);

                                                        SubTotal = DPrice[OptionIndex] * Qty;
                                                        SubTotalPrice = SubTotalPrice + SubTotal;
                                                        TotalPrice = SubTotalPrice;
                                                        OrderList.Add(order.PadRight(8) + DrinkMenu[OptionIndex].PadRight(25) +
                                                                                        DPrice[OptionIndex].ToString().PadLeft(10) +
                                                                                        Qty.ToString().PadLeft(10) + SubTotal.ToString("#,0.00").PadLeft(12));
                                                    }
                                                }

                                            } while (order != "D6");
                                            Console.Clear();
                                            PrintStock.OptionList(Option, Menu);
                                            break;
                                        case 4:
                                            Console.Clear();
                                           
                                            Console.WriteLine("Lantakan Fast food".PadLeft(25));
                                            Console.WriteLine();
                                            Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(30) + "Price".PadRight(10));
                                            for (int i = 0; i < Dessert.Length; i++)
                                            {
                                                if (EPrice[i] > 0) { StrPrice = EPrice[i].ToString(); }
                                                else { StrPrice = ""; }

                                                Console.WriteLine(Dessert[i].PadRight(8) + DessertMenu[i].PadRight(30) + StrPrice.PadRight(10));
                                            }
                                            do
                                            {
                                                Console.Write("Enter Code : ");
                                                order = Console.ReadLine().ToUpper();
                                                OptionIndex = Array.IndexOf(Dessert, order);
                                                if (OptionIndex < 0)
                                                {
                                                    Console.WriteLine("INVALID CODE!!!");
                                                }
                                                else
                                                {
                                                    if (order != "E6")
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
                                                                    if (EStock[OptionIndex] >= Qty)
                                                                    {
                                                                        Console.WriteLine();
                                                                    }
                                                                    else { Console.WriteLine($"We apologize, but we're currently low on stock and only have {EStock[OptionIndex]} of that item available. (Type 0 to Reset Order) "); }
                                                                }
                                                            } while ((EStock[OptionIndex] < Qty));
                                                        }
                                                        while (int.TryParse(StrQty, out Qty) == false);

                                                        SubTotal = EPrice[OptionIndex] * Qty;
                                                        SubTotalPrice = SubTotalPrice + SubTotal;
                                                        TotalPrice = SubTotalPrice;
                                                        OrderList.Add(order.PadRight(8) + DessertMenu[OptionIndex].PadRight(25) +
                                                                                        EPrice[OptionIndex].ToString().PadLeft(10) +
                                                                                        Qty.ToString().PadLeft(10) + SubTotal.ToString("#,0.00").PadLeft(12));
                                                    }
                                                }

                                            } while (order != "E6");
                                            Console.Clear();
                                            PrintStock.OptionList(Option, Menu);
                                            break; ;
                                    }

                                }
                            } while (order != "F");


                            if (TotalPrice > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Code".PadRight(8) + "Menu".PadRight(25) + "Price".PadLeft(10) +
                                               "Quantity".PadLeft(10) + "Subtotal".PadLeft(12));
                                foreach (var item in OrderList)
                                {
                                    Console.WriteLine($"{item}");
                                }
                                string StrTotal = "Total Amount : " + SubTotalPrice.ToString("#,0.00");
                                Console.WriteLine(StrTotal.PadLeft(65));

                                double AmountReceived = 0;
                                double Change = 0;
                                string StrAmount;

                                // Payment & Changee

                                do
                                {
                                    do
                                    {
                                        Console.Write("Enter Amount : ");
                                        StrAmount = Console.ReadLine();

                                    } while (double.TryParse(StrAmount, out AmountReceived) == false);
                                    if (Convert.ToDouble(StrAmount) < TotalPrice)
                                    {
                                        Console.WriteLine("Please enter a higher amount to match the total needed.");
                                        Console.WriteLine();
                                    }
                                } while (Convert.ToDouble(StrAmount) < TotalPrice);

                                Change = AmountReceived - TotalPrice;
                                Console.WriteLine("Change : " + Change.ToString("#,0.00"));
                                TotalSales = TotalSales + TotalPrice;
                            }
                            //Continue or not
                            do
                            {
                                Console.Write("Another transaction (Y/N) : ");
                                Transact = Console.ReadLine().ToUpper();

                            } while (Transact != "Y" && Transact != "N");

                            Console.Clear();
                        } while (Transact != ("N"));

                        Console.WriteLine("Thanks for Buying & Enjoy Eating!!!");
                         break;
                    case 3:
                        Console.WriteLine("Thanksssss");
                        break;
                }
            } while (WRU != 3);         
        }
         
    }
}

