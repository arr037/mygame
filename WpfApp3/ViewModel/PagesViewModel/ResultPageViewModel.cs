using System.Windows.Media;
using WpfApp3.Commands;
using WpfApp3.Navigator;
using WpfApp3.Views.Pages;

namespace WpfApp3.ViewModel.PagesViewModel
{
    public class ResultPageViewModel:Navigate
    {
        private string[] _buttonContents;
        private Brush[] _buttonBrushes;
        private string _whoWin;
        
        public string[] ButtonContents
        {
            get => _buttonContents;
            set => SetProperty(ref _buttonContents, value);
        }

        public Brush[] ButtonBrushes
        {
            get => _buttonBrushes;
            set => SetProperty(ref _buttonBrushes, value);
        }

        public string WhoWin
        {
            get => _whoWin;
            set => SetProperty(ref _whoWin, value);
        }
        
        public DelegateCommand NewGame { get; }

        public ResultPageViewModel(string WinPlayer,string[] btnParam,Brush[] btnBrushes)
        {
            NewGame = new DelegateCommand(NewGameVoid);
            WhoWin = WinPlayer;
            ButtonBrushes = btnBrushes;
            _buttonContents = btnParam;
        }

        private void NewGameVoid(object obj)
        {
            NavigateTo(new StartPage
            {
                DataContext = new StartPageViewModel()
            });
        }
    }
}