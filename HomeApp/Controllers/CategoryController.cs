using Business.Services;
using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helper;

namespace HomeApp.Controllers
{
    public class CategoryController
    {
       
        public CategoryService categoryService { get; }
        public CategoryController()
        {
            categoryService = new CategoryService();
        }

        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Green, "Enter Category typename:");
            string typeName = Console.ReadLine();
            EnterName: Helper.ChangeTextColor(ConsoleColor.Green, "Enter Category drug dose");
            string dose = Console.ReadLine();
            int maxDose;
            bool isTrueDose = int.TryParse(dose, out maxDose);
            if (isTrueDose)
            {
                Category category = new Category { TypeName = typeName, Dose = maxDose };
                if (categoryService.Create(category) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{category.TypeName} created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something is wrong!!!");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter Correct Size");
                goto EnterName;
            }

        }

        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "All categories:");
            foreach (Category category in categoryService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Green, $"{category.SerialId} - {category.TypeName}");
            }
        }
        public void Delete()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter category SerialId:");
            string input = Console.ReadLine();
            int categorySerialId;
            bool isTrue = int.TryParse(input, out categorySerialId);
            if (isTrue)
            {
                if (categoryService.Delete(categorySerialId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Category is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{categorySerialId} is not find");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Please, selected correct format");
            }
            
        }
        public void GetCategoriesWithDose()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter category dose:");
            string input = Console.ReadLine();
            int Dose;
            bool isTrue = int.TryParse(input, out Dose);
            if (isTrue)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Categories which dose is {Dose}:");
                foreach (var item in categoryService.GetAll(Dose))
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, item.TypeName);
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Please, select correct format");
        }
       

    }    
}

