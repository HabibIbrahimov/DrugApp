

using Business.Services;
using Enitites.Models;
using HomeApp.Controllers;
using System;
using Utilies.Helper;


namespace HomeApp
{
    class Program
    {
        private static int typename;

        static void Main(string[] args)

        {
            CategoryController categoryController = new CategoryController();
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Welcome");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue&&menu>=0&&menu<=7)
                {
                    switch (menu)
                    {
                        
                        case (int)Helper.Menu.CreateCategory:
                            categoryController.Create();

                            break;
                        case (int)Helper.Menu.UptadeCategory:
                            break;
                        case (int)Helper.Menu.DeleteCategory:
                            break;
                        case (int)Helper.Menu.GetCategoryWithSerialId:
                            break;
                        case (int)Helper.Menu.GetCategoryWithTypeName:
                            break;
                        case (int)Helper.Menu.GetAllCategory:
                            categoryController.GetAllCategory();
                            break;
                        case (int)Helper.Menu.GetCategoriesWithDose:
                            break;
                        case (int)Helper.Menu.Exit:
                            break;
                    }
                }
                else if (menu==0)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Goodbye");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please,select correct option");
                }

            }

        }

        static void ShowMenu()
        {
            Helper.ChangeTextColor(ConsoleColor.White,
                    "1-Create Category,2-Uptade Category,3-Delete Category,4-Get Category With SerialId," +
                    "5-Get Category With TypeName,6-Get All Category,7-Get Categories With Dose,0-Exit");
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Selected Option Number:");
        }
    }

}
