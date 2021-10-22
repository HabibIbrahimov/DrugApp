using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
   public interface ICategory
    {
        Category Create(Category category);
        Category Uptade(int SerialId ,Category category);
        Category Delete(int SerialId);
        Category Get(int SerialId);
        Category Get(string TypeName);
        List<Category> GetAll();
        List<Category> GetAll(int Dose);
    }
}
