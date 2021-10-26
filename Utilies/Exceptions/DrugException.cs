using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Exceptions
{
   public class DrugException:Exception
    {
        public DrugException(string message) : base(message)
        {
        }
    }
}
