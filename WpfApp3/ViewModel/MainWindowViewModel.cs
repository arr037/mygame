using System.Windows.Controls;
using WpfApp3.ViewModel.Base;
using WpfApp3.ViewModel.PagesViewModel;
using WpfApp3.Views.Pages;

namespace WpfApp3.ViewModel
{
    public class MainWindowViewModel:BaseViewModel
    {
        private UserControl _currentPage;

        public UserControl CurrentPage
        {
            get => _currentPage;
            set => SetProperty(ref _currentPage, value);
        }

        public MainWindowViewModel()
        {
            CurrentPage = new StartPage
            {
                DataContext = new StartPageViewModel()
            };
        }
        
    }
}