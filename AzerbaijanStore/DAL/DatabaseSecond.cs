using AzerbaijanStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerbaijanStore.DAL
{
    public class DatabaseSecond
    {
        public DatabaseSecond()
        {
            Users = Users ?? new EntitiyModel<User>();
            Fruits = Fruits ?? new EntitiyModel<Fruit>();
        }
        public static EntitiyModel<User> Users{ get; set; }
        public static EntitiyModel<Fruit> Fruits { get; set; }

    }



}
