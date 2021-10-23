﻿

using DataAccess.Repositories;
using Enitites.Models;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class CategoryService
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
                category.SerialId = count;
                Category isExist =
                   categoryRepository.Get(c => c.TypeName == category.TypeName);
                if (isExist != null)
                    return null;
                categoryRepository.Create(category);
                count++;
                return category;


            }
            catch (Exception)
            {

                return null;
            }
        }

        public Category Delete(int SerialId)
        {
            Category dbCategory = categoryRepository.Get(c => c.SerialId == SerialId);
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

        public Category Get(int SerialId)
        {
            throw new NotImplementedException();
        }

        public Category Get(string TypeName)
        {
           return categoryRepository.Get(c => c.TypeName == TypeName);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.Getall();
        }

        public List<Category> GetAll(int Dose)
        {
            return categoryRepository.Getall(c => c.Dose == Dose);
            
        }

        public Category Uptade(int SerialId, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
