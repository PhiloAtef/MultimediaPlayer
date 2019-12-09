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

        public void AddFirst (T _Data)
        {
            Node<T> temp = new Node<T>(_Data);

            if (head == null)
            {
                head = tail = temp;
            }
            else
            {
                temp.next = head;
                head.prev = temp;
                head = temp;
            }
        }

        public void AddEnd (T _Data)
        {
            Node<T> temp = new Node<T>(_Data);

            if (head == null)
            {
                head = temp;
                tail = temp;
            }
            else
            {
                tail.next = temp;
                temp.prev = tail;
                tail = temp;
            }
        }

        public void DelFirst(T _Data)
        {
            if (head == null)
            {
                return;
            }
            else
            {
                if (head.next!=null)
                {
                    head.next.prev=null;
                }
                head = head.next;
            }
        }

        public void DelLast(T _Data)
        {
            if (head==null)
            {
                return;
            }
            else if(head.next==null)
            {
                head = null;
            }
            else
            {
                Node<T> temp = head;

                while (temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.prev.next = null;
            }
        }

        public void Del(T _Data)
        {
            if (head==null)
            {
                return;
            }
            if (head.Data.Equals(_Data))
            {
                if (head.next!=null)
                {
                    head.next.prev = null;
                    head = head.next;
                    return;
                }
                else
                {
                    head = null;
                    return;
                }
            }          

            Node<T> current = head;
            Node<T> previous = null;
            while (current.next!=null&&!current.Data.Equals(_Data))
            {
                previous = current;
                current = current.next;
            }

            if (current.Data.Equals(_Data))
            {
                previous.next = current.next;
                if (previous.next!=null)
                {
                    previous.next.prev = previous;
                }
                else
                {
                    tail = previous;
                }
            }
            else
            {
                return;
            }
        }
    }
}
