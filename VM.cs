//Group - 1:-Yang Zhuoying, Kaur, Harsimrat, Keerthi, Aravind , Kour, Jaivleen, Lopez Puente, Laura Yessica, PATEL, ATMIYA ANILBHAI, Shajahan, Hashim Mohammed,
//   Syed, Saddam Hussain, Velaga, Swetha, Meet patel
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ball_Clock
{
    class VM : INotifyPropertyChanged
    {
        #region Methods

        int ballsCount;
        public int BallsCount
        {
            get => ballsCount;
            set
            {
                ballsCount = value;
                GetDays();
            }
        }

        string days;
        public string Days
        {
            get => days;
            set
            {
                days = value;
                propertyChanged();
            }
        }

        #endregion

        #region GetDays
        public void GetDays()
        {
            Queue<Ball> queue = new Queue<Ball>();
            for (int i = 0; i < ballsCount; i++)
            {
                queue.Enqueue(new Ball() { Number = i });
            }
            Clock clock = new Clock(queue);

            Days = $"{BallsCount} balls cycle after {clock.GetDays()} days";
        }

        #endregion

        #region PropertyChange
        public event PropertyChangedEventHandler PropertyChanged;
        private void propertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
