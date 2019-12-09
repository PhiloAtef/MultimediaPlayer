using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMediaPlayer
{
    class DoubleLinkedList<T>
    {
        Node<T> head;
        Node<T> tail;
        int count = 0;

        public DoubleLinkedList()
        {
            head = tail = null;
        }
    }
}
