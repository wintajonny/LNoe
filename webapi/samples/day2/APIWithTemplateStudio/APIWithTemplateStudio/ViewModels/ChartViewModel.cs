using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using APIWithTemplateStudio.Core.Models;
using APIWithTemplateStudio.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace APIWithTemplateStudio.ViewModels
{
    public class ChartViewModel : ObservableObject
    {
        public ObservableCollection<DataPoint> Source { get; } = new ObservableCollection<DataPoint>();

        public ChartViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Replace this with your actual data
            var data = await SampleDataService.GetChartDataAsync();
            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
