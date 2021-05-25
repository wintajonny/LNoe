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

namespace AsyncWPFApp
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

        private async void OnAdd(object sender, RoutedEventArgs e)
        {

            int x = int.Parse(text1.Text);
            int y = int.Parse(text2.Text);

            // with my own thread switch
            //int res = await Task<int>.Run(() =>
            //{
            //    var calc = new ComplexCalculations();
            //    int result = calc.Add(x, y);
            //    return result;
            //}).ConfigureAwait(continueOnCapturedContext: false);

            //this.Dispatcher.Invoke(() =>
            //{
            //    textResult.Text = res.ToString();
            //});


            // using async/await with sync context
            int res = await Task.Run(() =>
            {
                ComplexCalculations calc = new();
                int result = calc.Add(x, y);
                return result;
            });

            textResult.Text = res.ToString();
        }

        private void OnBackgroundWorker(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(text1.Text);
            int y = int.Parse(text2.Text);

            int result = 0;
            BackgroundWorker worker = new();
  
            worker.DoWork += (sender, e) =>
            {
                var calc = new ComplexCalculations();
                result = calc.Add(x, y);
            };
            
            worker.RunWorkerCompleted += (sender, e) =>
            {
                textResult.Text = result.ToString();
            };
            worker.RunWorkerAsync();
        }

        private async void OnAddWithProgress(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(text1.Text);
            int y = int.Parse(text2.Text);

            var calc = new ComplexCalculations();

            progress1.Visibility = Visibility.Visible;

            await foreach (var item in calc.GetAddResult(x, y))
            {
                if (item.Completed)
                {
                    textResult.Text = item.Value.ToString();
                    progress1.Visibility = Visibility.Hidden;
                }
                progress1.Value = item.Progress;

            }
        }
    }
}
