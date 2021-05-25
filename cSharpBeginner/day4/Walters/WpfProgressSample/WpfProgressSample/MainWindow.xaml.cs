using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfProgressSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task MyMethodAsync(int delay, IProgress<MyProgressReport> progress)
        {
            int total = 500;
            for (int i = 0; i < total; i++)
            {
                await Task.Delay(delay);
                progress.Report(new MyProgressReport { CurrentProgressAmount = i, TotalProgressAmount = total, CurrentProgressMessage = string.Format($"On {i} Message") } );
            }
        }

        private void ReportProgress(MyProgressReport progress)
        {
            rect.Width = (border.ActualWidth / progress.TotalProgressAmount) * progress.CurrentProgressAmount;
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var progressIndicator = new Progress<MyProgressReport>(ReportProgress);
            await MyMethodAsync(10, progressIndicator);

        }
    }

    public class MyProgressReport
    {
        public int CurrentProgressAmount { get; set; }
        public int TotalProgressAmount { get; set; }
        public string CurrentProgressMessage { get; set; }
    }
}
