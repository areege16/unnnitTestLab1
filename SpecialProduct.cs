using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectUnitTesting
{
    public class SpecialProduct:Product
    {
        public string Category { get; set; }

      

        public override string GetDescription()
        {
            return $"{Name} - {Price} - {Category}";
        }

        public bool IsValidPrice()
        {
            return Price > 50;
        }
     
    }
}
