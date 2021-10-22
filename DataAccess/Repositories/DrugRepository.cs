using DataAccess.Interfaces;
using Enitites.Interfaces;
using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DrugRepository : IRepository<Drug>

    {
        public bool Create(Drug entity)
        {
            try
            {
                DbContext.Drugs.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Drug entity)
        {
            try
            {
                DbContext.Drugs.Remove(entity);
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Drug Get(Predicate<Drug> filter = null)
        {
            try
            {
                return filter==null ? DbContext.Drugs[0]
                    : DbContext.Drugs.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Drug> Getall(Predicate<Drug> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Drugs
                    : DbContext.Drugs.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Uptade(Drug entity)
        {
            try
            {
                Drug dbDrug = Get(d => d.SerialId == entity.SerialId);
                dbDrug = entity;
                //dbDrug.Name = entity.Name;
                //dbDrug.Price = entity.Price;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
