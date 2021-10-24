using Enitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enitites.Models
{
   public class Category:IEntity
    {
        public int SerialId { get; set; }
        public string Name { get; set; }
        public int Dose { get; set; }

    }
}
