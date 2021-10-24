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

        public Drug Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Drug Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Drug> Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAll(string categoryName)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAll()
        {
            throw new NotImplementedException();
        }

        public Drug Update(Drug drug, string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
