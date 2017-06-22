using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst
{
    class Program
    {
        static void Main()
        {
            
            using (AdventureWorksDW2014Entities db = new AdventureWorksDW2014Entities())
            {
                var query = from prod in db.DimProduct
                                select prod;

                foreach (DimProduct p in query)
                {
                    Console.WriteLine($"{p.ProductKey}, {p.ModelName}");
                }

                
                var q2 = from cat in db.DimProductCategory
                         join prod in db.DimProduct on cat.ProductCategoryKey equals prod.ProductSubcategoryKey
                         where cat.EnglishProductCategoryName.ToLower().Contains("bike")
                         select prod;
              
                foreach (var p in q2)
                {
                    Console.WriteLine($"{p.DimProductSubcategory.EnglishProductSubcategoryName}, {p.ModelName}");
                }

                DimProductCategory cat1 = new DimProductCategory();
                cat1.EnglishProductCategoryName = "new category";
                cat1.FrenchProductCategoryName = "nouvelle catégorie";
                cat1.SpanishProductCategoryName = "nueva categoría";
                using (AdventureWorksDW2014Entities dba = new AdventureWorksDW2014Entities())
                {
                    dba.Database.ExecuteSqlCommand("DELETE from DimProductCategory WHERE EnglishProductCategoryName='new category'");
                    dba.DimProductCategory.Add(cat1);
                    dba.SaveChanges();
                }

                using (AdventureWorksDW2014Entities dbquery = new AdventureWorksDW2014Entities())
                {
                    var product1 = dbquery.DimProduct.Find(1);

                    var products = dbquery.DimProduct.SqlQuery("select * from DimProduct").ToList();

                    var productColorsQuery = dbquery.Database.SqlQuery<string>("select distinct Color from DimProduct");
                    List<string> names = productColorsQuery.ToList();


                    int affected = dbquery.Database.ExecuteSqlCommand("UPDATE DimCustomer SET Title='Dr' WHERE CustomerKey=1234");
                }

                Console.ReadLine();
            }
        }
    }
}
