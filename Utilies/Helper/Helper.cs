using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Helper
{
   public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public enum Menu
        {
            Exit,
            CreateCategory,
            UptadeCategory,
            DeleteCategory,
            GetCategoryWithId,
            GetCategoryWithName,
            GetAllCategory,
            GetCategoriesWithDose,
            CreateDrug,
            GetAllDrugWithCategory
            
        }
    }
}
