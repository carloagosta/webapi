using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Resources
{
    public class Point
    {
        public DateTime Date;
        public decimal Price;

        public Point(DateTime date, decimal price)
        {
            Date = date;
            Price = price;
        }
    }
}
