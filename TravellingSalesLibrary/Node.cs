using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesLibrary
{
    public class Node
    {
        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public bool Visited { get; set; } = false;
    }
}
