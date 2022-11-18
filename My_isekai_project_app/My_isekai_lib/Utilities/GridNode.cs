using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Utilities
{
    public class GridNode : IComparable<GridNode>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public NodeType Type { get; set; }
        public bool Visited { get; set; } = false;
        public int TentativeDistance { get; set; } = int.MaxValue;
        public GridNode Previous { get; set; }

        public GridNode(int x, int y, NodeType type = NodeType.Normal)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public int CompareTo(GridNode other)
        {
            return TentativeDistance - other.TentativeDistance;
        }
    }
}
