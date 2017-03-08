using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Rellotge_M07
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    

    public partial class MainWindow : Window
    {

        DispatcherTimer dispatcherTimer;
        DateTimeOffset startTime;


        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimerSetup();
        }

        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            startTime = DateTimeOffset.Now;

            dispatcherTimer.Start();
        }

        void dispatcherTimer_Tick(object sender, object e)
        {
            DateTimeOffset time = DateTimeOffset.Now;

            String hour = time.Hour.ToString();
            String minute = time.Minute.ToString();
            String second = time.Second.ToString();

            String currentTime = hour + ":" + minute + ":" + second;

            this.alarm.Content = currentTime;
            Boolean alarmActivated = checkAlarm.IsChecked.Value;
            if (alarmBox.Text == currentTime && alarmActivated)
            {
                MessageBox.Show("ALAAAAAAAAAAAAAAAAAAAAAAARMA");
            }
        }
        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimerSetup();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void onHelp(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gerard Fandos Garcia");
        }


    }
}
