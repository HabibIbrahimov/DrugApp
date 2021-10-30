using Business.Interfaces;
using DataAccess.Repositories;
using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Exceptions;

namespace Business.Services
{
    public class DrugService : IDrug
    {
        private DrugRepository drugRepository { get; }
        private CategoryService categoryService { get; }
        private static int count;
        public DrugService()
        {
            drugRepository = new DrugRepository();
            categoryService = new CategoryService();
        }
        public Drug Create(Drug drug, string categoryName)
        {
            Category dbCategory = categoryService.Get(categoryName);
            if (dbCategory != null)
            {
                drug.category = dbCategory;
                drug.Id = count;
                drugRepository.Create(drug);
                count++;
                return drug;
            }
            else
            {
                return null;
            }
        }
        public List<Drug> GetAll(string categoryName)
        {
            Category dbCategory = categoryService.Get(categoryName);
            if (dbCategory != null)
            {
                return drugRepository.Getall(d => d.category.Name.ToLower() == dbCategory.Name.ToLower());
            }
            else
            {
                return null;
            }
        }

        public Drug Delete(int id)
        {
            try
            {
                Drug dbDrug = drugRepository.Get(d => d.Id == id);
                if (dbDrug != null)
                {
                    drugRepository.Delete(dbDrug);
                    return dbDrug;
                }
                else
                {
                    Console.WriteLine(DrugException.DrugcategoryNotcreate);
                    return default;
                }
            }
            catch (DrugException)
            {

                Console.WriteLine(DrugException.DrugcategoryNotcreate);
                return default;
            }
            
            
        }

        public Drug Get(int id)
        {
           return drugRepository.Get(d => d.Id == id);
        }

        public List<Drug> Get(string name)
        {
            return drugRepository.Getall(d => d.Name.ToLower() == name.ToLower());
        }

        public List<Drug> GetAll()
        {
            return drugRepository.Getall();
        }

        public Drug Update(Drug drug, string category)
        {
            try
            {
                Drug dbDrug = drugRepository.Get(d => d.Id == drug.Id);
                dbDrug = drug;
                return dbDrug;
            }
            catch (DrugException)
            {
                Console.WriteLine(DrugException.DrugcategoryNotcreate);
                return default;
            }
        }
    }
}
