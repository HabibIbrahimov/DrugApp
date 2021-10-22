using DataAccess.Interfaces;
using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class CategoryRepository: IRepository<Category>

    {
        public bool Create(Category entity)
        {
            try
            {
                DbContext.Categories.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Category entity)
        {
            try
            {
                DbContext.Categories.Remove(entity);
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Category Get(Predicate<Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Categories[0]
                    : DbContext.Categories.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Category> Getall(Predicate<Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Categories
                    : DbContext.Categories.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Uptade(Category entity)
        {
            try
            {
                Category dbCategory = Get(d => d.SerialId == entity.SerialId);
                dbCategory = entity;
                //dbCategory.TypeName = entity.TypeName;
                //dbCategory.Dose = entity.Dose;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
