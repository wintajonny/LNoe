using System;
using System.Windows.Input;

using APIWithTemplateStudio.EventHandlers;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using Windows.UI.Xaml.Media.Imaging;

namespace APIWithTemplateStudio.ViewModels
{
    public class CameraViewModel : ObservableObject
    {
        private ICommand _photoTakenCommand;
        private BitmapImage _photo;

        public BitmapImage Photo
        {
            get { return _photo; }
            set { SetProperty(ref _photo, value); }
        }

        public ICommand PhotoTakenCommand => _photoTakenCommand ?? (_photoTakenCommand = new RelayCommand<CameraControlEventArgs>(OnPhotoTaken));

        private void OnPhotoTaken(CameraControlEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.Photo))
            {
                Photo = new BitmapImage(new Uri(args.Photo));
            }
        }
    }
}
