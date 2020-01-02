using System.Windows;
using System.Windows.Controls;
using WpfApp3.ViewModel;
using WpfApp3.ViewModel.Base;

namespace WpfApp3.Navigator
{
    public abstract class Navigate:BaseViewModel
    {
        protected void NavigateTo(UserControl page)
        {
            if(page==null)
                return;
            
            var mainWindowDt = Application.Current.MainWindow?.DataContext as MainWindowViewModel;
            if (mainWindowDt != null)
                mainWindowDt.CurrentPage = page;
        }
    }
}