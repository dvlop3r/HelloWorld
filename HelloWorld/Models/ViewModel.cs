using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class ViewModel
    {
        public IEnumerable<Employees> Employees { get; set; }
        public IEnumerable<Post> Posts{ get; set; }
    }
}
