using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YZU.Models.ViewModels
{
    public class OrderDetailsCart
    {
        public List<CourseCart> listCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
