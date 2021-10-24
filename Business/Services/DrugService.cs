using Business.Interfaces;
using DataAccess.Repositories;
using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
                drug.SerialId = count;
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
                return drugRepository.Getall(d => d.category.Name == dbCategory.Name);
            }
            else
            {
                return null;
            }
        }

        public Drug Delete(int Serialid)
        {
            Drug dbDrug = drugRepository.Get(d => d.SerialId == Serialid);
            if (dbDrug != null)
            {
                drugRepository.Delete(dbDrug);
                return dbDrug;
            }
            else
            {
                return null;
            }
        }

        public Drug Get(int serialid)
        {
            throw new NotImplementedException();
        }

        public List<Drug> Get(string name)
        {
            return drugRepository.Getall(d => d.Name.ToLower() == name.ToLower());
        }

        public List<Drug> GetAll()
        {
            return drugRepository.Getall();
        }

        public Drug Update(Drug drug, string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
