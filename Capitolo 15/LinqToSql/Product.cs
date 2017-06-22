using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    [Table(Name = "DimProduct")]
    class Product
    {
        [Column(IsPrimaryKey = true)]
        public int ProductKey { get; set; }
        [Column]
        public string EnglishProductName { get; set; }
        [Column]
        public string Color { get; set; }
    }

}
