//Group - 1:-Yang Zhuoying, Kaur Harsimrat, Keerthi Aravind , Kour Jaivleen, Lopez Puente, Laura Yessica, PATEL ATMIYA ANILBHAI, Shajahan Hashim Mohammed,
//   Syed Saddam Hussain, Velaga Swetha, Meet patel
using System.Collections.Generic;

namespace Ball_Clock
{
    class CopyQueue<T>
    {
        /*it will return the copy of queue
          will create the Queue<T> Class to copy it
         */
        public static Queue<T> Copy(Queue<T> queue)
        {
            Queue<T> queueCopy = new Queue<T>();
            int counter = queue.Count;
            for (int i = 0; i < counter; i++)
            {
                T element = queue.Dequeue();
                queueCopy.Enqueue(element);
                queue.Enqueue(element);
            }
            return queueCopy;
        }
    }
}
