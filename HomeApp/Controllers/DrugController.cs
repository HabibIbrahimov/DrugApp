﻿using Business.Services;
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
        public void GetAllDrugWithCategory()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select the category you want:");
            string categoryName = Console.ReadLine();
            List<Drug> drugs = drugService.GetAll(categoryName);
            if (drugs != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Category {categoryName}:");
                foreach (var item in drugs)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green,
                    $"{item.SerialId} - {item.Name} {item.Type}");
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red,
                $"Couldn't find such as Category - {categoryName}");
        }
        public void Delete()
        {
            
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter drug SerialId:");
            string input = Console.ReadLine();
            int drugSerialId;
            bool isTrue = int.TryParse(input, out drugSerialId);
            if (isTrue)
            {
                if (drugService.Delete(drugSerialId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Drug is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{drugSerialId} is not find");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Please, selected correct format");
            }
        }
        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "All drugs:");
            foreach (Drug drug in drugService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Green, $"{drug.SerialId} - {drug.Name}");
            }
        }
    }
}
