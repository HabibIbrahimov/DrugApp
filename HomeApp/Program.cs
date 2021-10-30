

using Business.Services;
using Enitites.Models;
using HomeApp.Controllers;
using System;
using Utilies.Helper;


namespace HomeApp
{
    class Program
    {
        static void Main(string[] args)

        {
            CategoryController categoryController = new CategoryController();
            DrugController drugController = new DrugController();
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Welcome");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue&&menu>=0&&menu<=9)
                {
                    switch (menu)
                    {
                        
                        case (int)Helper.Menu.CreateCategory:
                            categoryController.Create();

                            break;
                        case (int)Helper.Menu.UptadeCategory:
                            categoryController.Uptade();
                            break;
                        case (int)Helper.Menu.DeleteCategory:
                            categoryController.Delete();
                            break;
                        case (int)Helper.Menu.GetCategoryWithId:
                            break;
                        case (int)Helper.Menu.GetCategoryWithName:
                            break;
                        case (int)Helper.Menu.GetAllCategory:
                            categoryController.GetAll();
                            break;
                        case (int)Helper.Menu.GetCategoriesWithDose:
                            categoryController.GetCategoriesWithDose();
                            break;
                        case (int)Helper.Menu.Exit:
                            break;
                        case (int)Helper.Menu.CreateDrug:
                            categoryController.GetAll();
                            drugController.Create();
                            break;
                        case (int)Helper.Menu.GetAllDrugWithCategory:
                            categoryController.GetAll();
                            drugController.GetAllDrugWithCategory();
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
                    "1-Create Category,2-Uptade Category,3-Delete Category,4-Get Category With Id," +
                    "5-Get Category With TypeName,6-Get All Category,7-Get Categories With Dose,8-Create Drug,9-Get All Drug With Category 0-Exit");
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Selected Option Number:");
        }
    }

}
