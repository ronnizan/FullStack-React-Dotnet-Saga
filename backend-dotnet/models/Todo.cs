using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Todo
    {


        public int id { get; set; }
        public string description { get; set; }
        public bool isCompleted { get; set; }
    }
}
