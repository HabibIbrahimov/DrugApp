using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
   public interface ICategory
    {
        Category Create(Category category);
        Category Uptade(int Id ,Category category);
        Category Delete(int Id);
        Category Get(int Id);
        Category Get(string Name);
        List<Category> GetAll();
        List<Category> GetAll(int Dose);
    }
}
