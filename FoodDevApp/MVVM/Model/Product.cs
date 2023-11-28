using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDevApp.MVVM.Model
{
    internal class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product Clone() => MemberwiseClone() as Product;
    }
}
