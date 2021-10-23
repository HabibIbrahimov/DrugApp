using Enitites.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IDrug
    {

        Drug Create(Drug drug, string categoryName);
        Drug Delete(int id);
        Drug Update(Drug drug, string categoryName);
        Drug Get(int id);
        List<Drug> Get(string name);
        List<Drug> GetAll(string categoryName);
        List<Drug> GetAll();
    }
}
