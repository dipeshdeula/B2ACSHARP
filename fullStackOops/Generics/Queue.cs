using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Generics
{
    public class Queue<T>
    {
        int size;
        int front = 0;
        int rear = -1;

        T[] arr;
        public Queue()
        {
            size = 5;
            arr = new T[size];
        }
        public Queue(int size) {
            this.size = size;
            arr = new T[size];
        }

        bool isEmpty()
        {
            if (rear == -1 || front > rear)
            {
                return true;
            }
            return false;
        }

        bool isFull()
        {

            return rear == size - 1;
        
        }

        public void Enqueue(T item)
        {
            if (isFull())
            { 
                Console.WriteLine("No space ! full cha");
                return ;
            }
            
            arr[++rear] = item;
            Console.WriteLine("Data inserted: " + item );
        }

        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Data not found ! Insert Data");
                return ;
            }

            Console.WriteLine("Dequeued item: "+arr[front]);
            front++;
        
        }

    }


    //main method
    class Program
    {
      /*  public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(7);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);   
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(12);

        }*/
    }
}
