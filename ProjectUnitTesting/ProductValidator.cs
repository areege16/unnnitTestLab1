using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUnitTesting
{
    class ProductValidator
    {
        public bool IsValidName(string name)
        {
            return !string.IsNullOrEmpty(name) && name.Length > 3;
        }

        public bool IsValidPrice(decimal price)
        {
            return price > 0;
        }

        public bool IsCategoryMatch(string category)
        {
            var validCategories = new List<string> { "Electronics", "Clothing", "Home" };
            return validCategories.Contains(category);
        }
    }
}
