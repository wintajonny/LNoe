using System;
using System.Threading.Tasks;
using System.Windows.Input;

using APIWithTemplateStudio.Core.Helpers;
using APIWithTemplateStudio.Core.Services;
using APIWithTemplateStudio.Helpers;
using APIWithTemplateStudio.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using Windows.ApplicationModel;
using Windows.UI.Xaml;

namespace APIWithTemplateStudio.ViewModels
{
    // TODO WTS: Add other settings as necessary. For help see https://github.com/Microsoft/WindowsTemplateStudio/blob/release/docs/UWP/pages/settings.md
    public class SettingsViewModel : ObservableObject
    {
        private UserDataService UserDataService => Singleton<UserDataService>.Instance;

        private IdentityService IdentityService => Singleton<IdentityService>.Instance;

        private ElementTheme _elementTheme = ThemeSelectorService.Theme;
        private RelayCommand _logInCommand;
        private RelayCommand _logOutCommand;
        private bool _isLoggedIn;
        private bool _isBusy;
        private UserViewModel _user;

        public ElementTheme ElementTheme
        {
            get { return _elementTheme; }

            set { SetProperty(ref _elementTheme, value); }
        }

        private string _versionDescription;

        public string VersionDescription
        {
            get { return _versionDescription; }

            set { SetProperty(ref _versionDescription, value); }
        }

        private ICommand _switchThemeCommand;

        public ICommand SwitchThemeCommand
        {
            get
            {
                if (_switchThemeCommand == null)
                {
                    _switchThemeCommand = new RelayCommand<ElementTheme>(
                        async (param) =>
                        {
                            ElementTheme = param;
                            await ThemeSelectorService.SetThemeAsync(param);
                        });
                }

                return _switchThemeCommand;
            }
        }

        public RelayCommand LogInCommand => _logInCommand ?? (_logInCommand = new RelayCommand(OnLogIn, () => !IsBusy));

        public RelayCommand LogOutCommand => _logOutCommand ?? (_logOutCommand = new RelayCommand(OnLogOut, () => !IsBusy));

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { SetProperty(ref _isLoggedIn, value); }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                SetProperty(ref _isBusy, value);
                LogInCommand.NotifyCanExecuteChanged();
                LogOutCommand.NotifyCanExecuteChanged();
            }
        }

        public UserViewModel User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        public SettingsViewModel()
        {
        }

        public async Task InitializeAsync()
        {
            VersionDescription = GetVersionDescription();
            IdentityService.LoggedIn += OnLoggedIn;
            IdentityService.LoggedOut += OnLoggedOut;
            UserDataService.UserDataUpdated += OnUserDataUpdated;
            IsLoggedIn = IdentityService.IsLoggedIn();
            User = await UserDataService.GetUserAsync();
        }

        private string GetVersionDescription()
        {
            var appName = "AppDisplayName".GetLocalized();
            var package = Package.Current;
            var packageId = package.Id;
            var version = packageId.Version;

            return $"{appName} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }

        public void UnregisterEvents()
        {
            IdentityService.LoggedIn -= OnLoggedIn;
            IdentityService.LoggedOut -= OnLoggedOut;
            UserDataService.UserDataUpdated -= OnUserDataUpdated;
        }

        private void OnUserDataUpdated(object sender, UserViewModel userData)
        {
            User = userData;
        }

        private async void OnLogIn()
        {
            IsBusy = true;
            var loginResult = await IdentityService.LoginAsync();
            if (loginResult != LoginResultType.Success)
            {
                await AuthenticationHelper.ShowLoginErrorAsync(loginResult);
                IsBusy = false;
            }
        }

        private async void OnLogOut()
        {
            IsBusy = true;
            await IdentityService.LogoutAsync();
        }

        private void OnLoggedIn(object sender, EventArgs e)
        {
            IsLoggedIn = true;
            IsBusy = false;
        }

        private void OnLoggedOut(object sender, EventArgs e)
        {
            User = null;
            IsLoggedIn = false;
            IsBusy = false;
        }
    }
}
