//Group - 1:-Yang Zhuoying, Kaur Harsimrat, Keerthi Aravind , Kour Jaivleen, Lopez Puente, Laura Yessica, PATEL ATMIYA ANILBHAI, Shajahan Hashim Mohammed,
//   Syed Saddam Hussain, Velaga Swetha, Meet patel
using Ball_Clock;
using System.Windows;

namespace ball_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
