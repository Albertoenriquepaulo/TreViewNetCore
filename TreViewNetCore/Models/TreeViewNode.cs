using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreViewNetCore.Models
{
    //This is class to use in the ViewModel
    public class TreeViewNode
    {
        public string id { get; set; }
        public string parent { get; set; }
        public string text { get; set; }
    }
}
