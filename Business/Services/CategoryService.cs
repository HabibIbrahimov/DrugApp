

using Business.Interfaces;
using DataAccess.Repositories;
using Enitites.Models;
using System;
using System.Collections.Generic;
using Utilies.Exceptions;

namespace Business.Services
{
    public class CategoryService:ICategory
    {
        public CategoryRepository categoryRepository { get; set; }
        private static int count { get; set; }
        public CategoryService()
        {
             categoryRepository = new CategoryRepository();
        }


        public Category Create(Category category)
        {
            try
            {
                category.Id = count;
                Category isExist =
                   categoryRepository.Get(c => c.Name.ToLower() == category.Name.ToLower());
                if (isExist != null)
                    return null;
                categoryRepository.Create(category);
                count++;
                return category;


            }
            catch (DrugException)
            {

                Console.WriteLine(DrugException.DrugcategoryNotcreate);
                return default;
            }
        }

        public Category Delete(int id)
        {
            Category dbCategory = categoryRepository.Get(c => c.Id == id);
            if(dbCategory != null)
            {
                categoryRepository.Delete(dbCategory);
                return dbCategory;
            }
            else
            {
                return null;
            }
        }

        public Category Get(int id)
        {
           return categoryRepository.Get(c => c.Id == id);
        }

        public Category Get(string Name)
        {
          Category dbCategory = categoryRepository.Get(c => c.Name.ToLower() == Name.ToLower());
            
            if (dbCategory != null)
            {
                return dbCategory;
            }
            else
            {
                return null;
            }

        }

        public List<Category> GetAll()
        {
            return categoryRepository.Getall();
        }

        public List<Category> GetAll(int Dose)
        {
            return categoryRepository.Getall(c => c.Dose == Dose);
            
        }

        public Category Uptade(int id, Category category)
        {
            try
            {
                Category dbCategory = categoryRepository.Get(c => c.Id == id);
                if (dbCategory != null)
                {
                    dbCategory.Name = category.Name;
                    dbCategory.Dose = category.Dose;
                    return dbCategory;

                }
                return null;

            }
            catch (DrugException)
            {
                return null;
            }
           

        }

       
    }
}
