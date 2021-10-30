using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Exceptions
{
    public class DrugException:Exception
    {
        public static string DrugcategoryNotcreate = "Couldnt can not category";

        public DrugException(string message) : base(message)
        {
        }
    }
}
