using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.InventoryManagement
{
    internal class Inventory
    {
        public static List<Product> SortProducts(List<Product> products, string sortKey, bool ascending)
        {
            Func<Product, object> keySelector = sortKey switch
            {
                "name" => p => p.Name,
                "price" => p => p.Price,
                "stock" => p => p.Stock,
                _ => throw new ArgumentException("This sork key doesn't exists")
            };

            if (ascending)
            {
                return products.OrderBy(keySelector).ToList();
            }
            else
            {
                return products.OrderByDescending(keySelector).ToList();
            }
        }
    }
}
