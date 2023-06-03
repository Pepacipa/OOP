using System.Windows;
using практика_5;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IMeasuringDevice measuringDevice;
        public MainWindow()
        {
            InitializeComponent();
        }       

        private void CreateInstance_Click(object sender, RoutedEventArgs e)
        {
            if (Mass.IsChecked == true) 
            {
                if (Imperial.IsChecked == true)
                {
                    measuringDevice = new MeasureMassDevice(Units.Imperial);
                }
                else if (Metric.IsChecked == true)
                {
                    measuringDevice = new MeasureMassDevice(Units.Metric);
                }
            }
            else if (Length.IsChecked == true)
            {
                if (Imperial.IsChecked == true)
                {
                    measuringDevice = new MeasureLengthDevice(Units.Imperial);
                }
                else if (Metric.IsChecked == true)
                {
                    measuringDevice = new MeasureLengthDevice(Units.Metric);
                }
            }           
        }

        private void StartCollecting_Click(object sender, RoutedEventArgs e)
        {
            measuringDevice.StartCollecting();
        }

        private void GetRawData_Click(object sender, RoutedEventArgs e)
        {
            int[] RawData = measuringDevice.GetRawData();
            ListRawData.Items.Clear();
            foreach (int i in RawData)
            {
                ListRawData.Items.Add(i);
            }
        }
        private void GetMetricValue_Click(object sender, RoutedEventArgs e)
        {
            decimal MetricValue = measuringDevice.MetricValue();
            LabelMerticValue.Content = MetricValue.ToString();
        }

        private void GetImperialValue_Click(object sender, RoutedEventArgs e)
        {
            decimal ImperialValue = measuringDevice.ImperialValue();
            LabelImperialValue.Content = ImperialValue.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            measuringDevice.StartCollecting();
        }
        private void StopCollecting_Click_1(object sender, RoutedEventArgs e)
        {
            measuringDevice.StopCollecting();
        }

        private void Metric_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Imperial_Checked(object sender, RoutedEventArgs e)
        {

        }
         
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


    }
}
