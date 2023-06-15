//Group - 1:-Yang Zhuoying, Kaur Harsimrat, Keerthi Aravind , Kour Jaivleen, Lopez Puente, Laura Yessica, PATEL ATMIYA ANILBHAI, Shajahan Hashim Mohammed,
//   Syed Saddam Hussain, Velaga Swetha, Meet patel
using System.Collections.Generic;

namespace Ball_Clock
{
    class Clock
    {
        static Stack<Ball> hourTrack;
        static Stack<Ball> FiveMinutesTrack;
        static Stack<Ball> minutesTrack;
        static Queue<Ball> originalQueue;

        const int Total_Balls_In_MinutesTrack = 5;
        const int Total_Balls_In_FiveMinutes_Track = 12;
        const int Total_Balls_In_Hour_Track = 12;

        public Clock(Queue<Ball> queue)
        {
            originalQueue = queue;
            minutesTrack = new Stack<Ball>();
            FiveMinutesTrack = new Stack<Ball>();
            hourTrack = new Stack<Ball>();
        }

        public double GetDays()
        {
            Queue<Ball> currentQueue = CopyQueue<Ball>.Copy(originalQueue);
            double days = 0; // initial state is 0 days
            do
            {
                minutesTrack.Push(currentQueue.Dequeue());
                if (minutesTrack.Count == Total_Balls_In_MinutesTrack)
                {
                    FiveMinutesTrack.Push(minutesTrack.Pop());
                    while (minutesTrack.Count != 0)
                    {
                        currentQueue.Enqueue(minutesTrack.Pop());
                    }
                }
                if (FiveMinutesTrack.Count == Total_Balls_In_FiveMinutes_Track)
                {
                    hourTrack.Push(FiveMinutesTrack.Pop());
                    while (FiveMinutesTrack.Count != 0)
                    {
                        currentQueue.Enqueue(FiveMinutesTrack.Pop());
                    }
                }
                if (hourTrack.Count == Total_Balls_In_Hour_Track)
                {
                    Ball last_Tray = hourTrack.Pop();
                    while (hourTrack.Count != 0)
                    {
                        currentQueue.Enqueue(hourTrack.Pop());
                    }
                    currentQueue.Enqueue(last_Tray);
                    days += 0.5;
                }
                // The do loop will run until the currentqueue doesnt equal to the origenal queue
            } while (!isEqual(currentQueue, originalQueue));
            return days;
        }
        //checking if the two queues are equal
        bool isEqual(Queue<Ball> queue1, Queue<Ball> queue2)
        {
            //create clones of queues
            Queue<Ball> copy1 = CopyQueue<Ball>.Copy(queue1);
            Queue<Ball> copy2 = CopyQueue<Ball>.Copy(queue2);

            //We are getting the elements of queues one by one. If elements equal and no more elements in queues - queues are equal
            while (copy1.Dequeue().Equals(copy2.Dequeue())) //while this and copy1.count is true the loop will continue 
            {
                if (copy1.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
