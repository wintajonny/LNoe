using System;

using APIWithTemplateStudio.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace APIWithTemplateStudio.Views
{
    public sealed partial class ListDetailsDetailControl : UserControl
    {
        public SampleOrder ListMenuItem
        {
            get { return GetValue(ListMenuItemProperty) as SampleOrder; }
            set { SetValue(ListMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(SampleOrder), typeof(ListDetailsDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));

        public ListDetailsDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ListDetailsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
