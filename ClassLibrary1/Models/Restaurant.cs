using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CuisineTybe Cuisine { get; set; }
    }
}
