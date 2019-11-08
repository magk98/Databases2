using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy2{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Category name: ");
            String categoryName = Console.ReadLine();
            Category category = new Category();
            category.Name = categoryName;
            ProdContext prodContext = new ProdContext();
            prodContext.Categories.Add(category);
            prodContext.SaveChanges();

            Console.WriteLine("Available categories are:");
            foreach (Category c in prodContext.Categories){
                Console.WriteLine("- " + c.Name);
            }
        }
    }
}
