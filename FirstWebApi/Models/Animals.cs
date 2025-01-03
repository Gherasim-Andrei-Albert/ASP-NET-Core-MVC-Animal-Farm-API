using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Models
{
    public class Animals
    {
        public int ID { get; set; }
        public int AnimalTypeID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public int OwnerID { get; set; }
        public int LocationID { get; set; }
    }
}
