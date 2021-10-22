

using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helper;


namespace HomeApp
{
    class Program
    {
        private static int typename;

        static void Main(string[] args)
        {
            CategoryService categoryService = new CategoryService();
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Welcome");
            while (true)
            {
                Helper.ChangeTextColor(ConsoleColor.White,
                    "1-Create Category,2-Uptade Category,3-Delete Category,4-Get Category with SerialId," +
                    "5-Get Category with TypeName,6-AllCategory,7-Get Categories with quantity");
                Helper.ChangeTextColor(ConsoleColor.Yellow, "Selected Option Number:");
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue&&menu>=1&&menu<=7)
                {
                    switch (menu)
                    {
                        case 1:
                            Helper.ChangeTextColor(ConsoleColor.Green, "Enter Category typename:");
                            string TypeName = Console.ReadLine();
                           EnterName: Helper.ChangeTextColor(ConsoleColor.Green, "Enter Category drug dose");
                            string dose = Console.ReadLine();
                            int maxDose;
                            bool isTrueDose = int.TryParse(dose, out maxDose);
                            if (isTrueDose)
                            {
                                Category category = new Category { TypeName=typename, Dose = maxDose };
                                
                            }
                            else
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Enter Correct Size");
                                goto EnterName;
                            }

                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                            
                    }
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please,select correct option");
                }
                
            }

        }
    }
}
