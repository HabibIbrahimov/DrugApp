using System;
using System.Collections.Generic;
using System.Text;
using Enitites.Interfaces;

namespace Enitites.Models
{
   public class Drug:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Category category { get; set; }
        
        
    }
}
