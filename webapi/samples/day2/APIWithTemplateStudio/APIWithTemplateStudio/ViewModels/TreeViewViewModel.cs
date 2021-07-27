using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using APIWithTemplateStudio.Core.Models;
using APIWithTemplateStudio.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using WinUI = Microsoft.UI.Xaml.Controls;

namespace APIWithTemplateStudio.ViewModels
{
    public class TreeViewViewModel : ObservableObject
    {
        private ICommand _itemInvokedCommand;
        private object _selectedItem;

        public object SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        public ObservableCollection<SampleCompany> SampleItems { get; } = new ObservableCollection<SampleCompany>();

        public ICommand ItemInvokedCommand => _itemInvokedCommand ?? (_itemInvokedCommand = new RelayCommand<WinUI.TreeViewItemInvokedEventArgs>(OnItemInvoked));

        public TreeViewViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            var data = await SampleDataService.GetTreeViewDataAsync();
            foreach (var item in data)
            {
                SampleItems.Add(item);
            }
        }

        private void OnItemInvoked(WinUI.TreeViewItemInvokedEventArgs args)
            => SelectedItem = args.InvokedItem;
    }
}
