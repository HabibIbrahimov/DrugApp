using Business.Services;
using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helper;

namespace HomeApp.Controllers
{
   public class DrugController
    {
        private DrugService drugService { get; }
        public DrugController()
        {
            drugService = new DrugService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select the category you want:");
            string categoryName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter drug name:");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter drug type:");
            string type = Console.ReadLine();
            Drug drug = new Drug { Name = name, Type = type };
            Drug newDru = drugService.Create(drug, categoryName);
            if (newDru !=null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green, 
                    $"New Drug is Created - {newDru.Name} {newDru.Type}");
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, 
                $"Couldn't find such as Category - {categoryName}");

        }
    }
}
