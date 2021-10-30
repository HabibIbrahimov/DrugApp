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
            Helper.ChangeTextColor(ConsoleColor.Green, "Enter Category name:");
            string name = Console.ReadLine();
            EnterName: Helper.ChangeTextColor(ConsoleColor.Green, "Enter Category drug dose");
            string dose = Console.ReadLine();
            int maxDose;
            bool isTrueDose = int.TryParse(dose, out maxDose);
            if (isTrueDose)
            {
                Category category = new Category { Name = name, Dose = maxDose };
                if (categoryService.Create(category) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{category.Name} created");
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
                Helper.ChangeTextColor(ConsoleColor.Green, $"{category.Id} - {category.Name}");
            }
        }
        public void Delete()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter category Id:");
            string input = Console.ReadLine();
            int categoryId;
            bool isTrue = int.TryParse(input, out categoryId);
            if (isTrue)
            {
                if (categoryService.Delete(categoryId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Category is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{categoryId} is not find");
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
                    Helper.ChangeTextColor(ConsoleColor.Cyan, item.Name);
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Please, select correct format");
        }
        public void Uptade()
        {
        Name: Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter  category Id:");
            string ID = Console.ReadLine();
            int id;
            bool isTrue = int.TryParse(ID, out id);
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter new category:");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Category new max drug dose:");
            string dose = Console.ReadLine();
            int maxDose;
            bool isTrueSize = int.TryParse(dose, out maxDose);
            if (isTrueSize && isTrue)
            {
                Category category = new Category { Name = name, Dose = maxDose };
                if (categoryService.Uptade(id, category) != null)
                {
                    
                    Helper.ChangeTextColor(ConsoleColor.Green, "Uptade Succes full:");


                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something is wrong!!!");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter Correct Category Dose or Id");
                goto Name;
            }

        }


    }    
}

