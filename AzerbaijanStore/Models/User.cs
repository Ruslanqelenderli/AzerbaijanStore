﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerbaijanStore.Models
{
    public class User:Entity
    {
        
        public string  Surname  { get; set; }
        public string WorkID { get; set; }
        public string Password { get; set; }
        
    }
}
