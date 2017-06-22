using EFCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CarContext db = new CarContext())
            {
                //db.Database.Connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCodeFirst.CarContext;Integrated Security=True;MultipleActiveResultSets=True";
                Car c = new Car();
                c.Targa = "abc";
                c.Modello = "Alfa Romeo GT";

                Person p = new Person();
                p.FirstName = "Antonio";
                p.LastName = "Pelleriti";
                c.Person = p;

                db.Cars.Add(c);
                db.People.Add(p);

                db.SaveChanges();
            }


        }
    }
}
