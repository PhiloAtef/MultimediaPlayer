using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMediaPlayer
{
    class Node<T>
    {
        T NodeData;
        Node<T> Next;
        Node<T> Prev;

        public T Data
        {
            get { return NodeData; }
            set { NodeData = value; }
        }

        public Node<T> _Next 
        {
            get { return Next; }
            set { Next = value; }
        }

        public Node<T> _Prev
        {
            get { return Prev; }
            set { Prev = value; }
        }

        public Node(T d)
        {
            NodeData = d;
            Next = null;
            Prev = null;
        }

    }
}
