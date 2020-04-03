using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreViewNetCore.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}
