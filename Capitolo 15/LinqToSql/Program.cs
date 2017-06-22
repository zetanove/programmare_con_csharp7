using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=(LocalDb)\\MSSQLLocalDb;Integrated Security=true;database=AdventureWorksDW2014";
            DataContext context = new DataContext(connString);

            var tableProd = context.GetTable<Product>();
            var products = from prod in tableProd
                           where prod.Color == "Black"
                           select prod;

            foreach (Product p in products)
            {
                Console.WriteLine(p.EnglishProductName);
            }

            Product product = products.First();
            product.Color = "Red";
            context.SubmitChanges();

            AdventureWorksDataContext awdc = new AdventureWorksDataContext(connString);
            var categories = awdc.DimProductCategories;

            foreach (DimProductCategory pc in categories)
            {
                Console.WriteLine(pc.EnglishProductCategoryName);
                foreach (var sub in pc.DimProductSubcategories)
                {
                    Console.WriteLine(sub.EnglishProductSubcategoryName);
                    foreach (var pd in sub.DimProducts)
                        Console.WriteLine("   {0}", pd.EnglishProductName);
                }
            }

            var query = from cat in categories
                        from sub in cat.DimProductSubcategories
                        from prod in sub.DimProducts
                        where cat.EnglishProductCategoryName.Contains("Bikes")
                        select prod;

            foreach (var p in query)
            {
                Console.WriteLine("{0}", p.EnglishProductName);
            }

            awdc.DimProducts.First().Color = "Dark Red";
            awdc.SubmitChanges();

            DimProductCategory newCat = new DimProductCategory();
            newCat.EnglishProductCategoryName = "New Category 1";
            newCat.SpanishProductCategoryName = "Nueva Categoria 1";
            newCat.FrenchProductCategoryName = "Nouvelle Categorie 1";
            awdc.DimProductCategories.InsertOnSubmit(newCat);
            awdc.SubmitChanges();
        }
    }
}
