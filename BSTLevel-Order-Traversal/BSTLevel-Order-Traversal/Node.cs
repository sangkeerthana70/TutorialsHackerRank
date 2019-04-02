using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTLevel_Order_Traversal
{
    class Node
    {
        public Node left;
        public Node right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
