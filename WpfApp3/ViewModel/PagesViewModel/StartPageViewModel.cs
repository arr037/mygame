using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfApp3.Commands;
using WpfApp3.Core.Mode;
using WpfApp3.Navigator;
using WpfApp3.ViewModel.Base;
using WpfApp3.Views.Pages;

namespace WpfApp3.ViewModel.PagesViewModel
{
    public class StartPageViewModel:Navigate
    {
        private string _player1;
        private string _player2;
        private GameMode _gameMode = GameMode.None;
        public string Player1
        {
            get => _player1;
            set => SetProperty(ref _player1, value);
        }
        public string Player2
        {
            get => _player2;
            set => SetProperty(ref _player2, value);
        }

        public GameMode GameMode
        {
            get => _gameMode;
            set => SetProperty(ref _gameMode, value);
        }

        public DelegateCommand GetClick { get; set; }
        public DelegateCommand CloseErrors { get; set; }
        public StartPageViewModel()
        {
            GetClick = new DelegateCommand(Exec);
            CloseErrors = new DelegateCommand(Errors);
        }

        private void Exec(object obj)
        {
             var err = CheckHasError();
            if (err.Length > 0)
            {
                string v = string.Join("\n" ,err);
                OverlayService.GetInstance().Text = v;
                return;
            }
            OverlayService.GetInstance().Visibility = Visibility.Visible;
            NavigateTo(new GamePage
            {
                DataContext = new GamePageViewModel(GameMode,Player1,Player2),
            });
        }

        private void Errors(object obj)
        {
            OverlayService.GetInstance().Text = "";
        }
        
        private string[] CheckHasError()
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrWhiteSpace(Player1))
                errors.Add("Введите корректно имя 1 игрока");
            
            if (string.IsNullOrWhiteSpace(Player2))
            {
                errors.Add("Введите корректно имя 2 игрока");
            }
                
            if(Player1 == Player2)
                errors.Add("Имена игроков не должны совпадать");

            if(GameMode== GameMode.None)
                errors.Add("Выберите режим игры");
            var i = 1;
            var b = errors.Select(x => $"{i++}. {x}");

            return b.ToArray();
        }
        
        
    }
}