using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDevApp.MVVM.Model
{
    [Table("User")]
    class Users
    {
        [PrimaryKey]
        [AutoIncrement]
        
        public int Id { get; set; }
        [Column("User_name")]
        public string UserName { get; set; }
        [Column("User_Email")]
        public string Email { get; set; }
    }
}
