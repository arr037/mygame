using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp3.Commands;
using WpfApp3.Core;
using WpfApp3.Core.Mode;
using WpfApp3.Helpers;
using WpfApp3.Model;
using WpfApp3.Navigator;
using WpfApp3.ViewModel.Base;
using WpfApp3.Views.Pages;

namespace WpfApp3.ViewModel.PagesViewModel
{
    public class GamePageViewModel : Navigate
    {
        private ObservableCollection<Elements> _elements;
        private string[] buttonsContent;
        public ObservableCollection<Elements> Elements
        {
            get => _elements;
            set => SetProperty(ref _elements, value);
        }
        private Elements _selectedItem;
        public Elements SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }
        
        private Brush[] brushes;
        private CellState[] cellStates;
        private string _whoMove;
        private bool _whyMove = true;
        public string WhoMove
        {
            get => _whoMove;
            set => SetProperty(ref _whoMove, value);
        }
        public DelegateCommand GetClick { get; set; }
        public GamePageViewModel(GameMode gameMode,string player1,string player2)
        {
            Mode(gameMode);
            GetClick = new DelegateCommand(ClickButton);
            brushes = new Brush[9];
            buttonsContent = new string[9];
            cellStates = new CellState[9];
            brushes.Fill(new SolidColorBrush(Colors.White));
            cellStates.Fill(CellState.NotSelected);
            
            _player1 = player1;
            _player2 = player2;
            WhoMove = _player1;

            OverlayService.GetInstance().Visibility = Visibility.Collapsed;
        }

        private void ClickButton(object obj)
        {
            if (!(obj is Button btn)) return;
            try
            {
                var btnNumber = Convert.ToInt32((string)btn.Tag);

                if (cellStates[btnNumber] != CellState.NotSelected) return;
                
                btn.Content = SelectedItem.ElementName;
                Button_Click(btnNumber, btn.Content.ToString());
                        
                WhoMove = _whyMove ? _player2 : _player1;
                _whyMove = !_whyMove;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private readonly string _player2;
        private readonly string _player1;

        #region CheckStateGame

        private void Button_Click(int btnNumber, string value)
        {
            if (cellStates[btnNumber] == CellState.NotSelected)
            {
                buttonsContent[btnNumber] = value;
                if (IsMetal(value))
                {
                    cellStates[btnNumber] = CellState.O;
                }
                else
                {
                    cellStates[btnNumber] = CellState.X;
                }

                Elements.Remove(SelectedItem);
                SelectedItem = null;
            }

            switch (GetGameResult())
            {
                case GameResult.CrossWin:
                    GenerateResult(_player2);
                    break;
                case GameResult.ZeroWin:
                    GenerateResult(_player1);
                    break;
                case GameResult.Draw:
                    MessageBox.Show("Ничья");
                    break;
                case GameResult.ContinueToPlay:
                    break;
            }
        }


        private GameResult GetGameResult()
        {
            if (CheckCellState(CellState.O))
                return GameResult.ZeroWin;
            if (CheckCellState(CellState.X))
                return GameResult.CrossWin;
            if (cellStates.All(c => c != CellState.NotSelected)) //Проверить каждый элемент массива cellStates не равен ли он CellState.NotSelected. Если все неравны, то ничья.
                return GameResult.Draw;
            return GameResult.ContinueToPlay;
        }

        private bool CheckCellState(CellState cellState)
        {

            if (cellStates[0] == cellState && cellStates[1] == cellState && cellStates[2] == cellState)
            {
                brushes[0] = new SolidColorBrush(Colors.Green);
                brushes[1] = new SolidColorBrush(Colors.Green);
                brushes[2] = new SolidColorBrush(Colors.Green);
                return true;
            }

            if (cellStates[3] == cellState && cellStates[4] == cellState && cellStates[5] == cellState)
            {
                brushes[3]= new SolidColorBrush(Colors.Green);
                brushes[4]= new SolidColorBrush(Colors.Green);
                brushes[5] = new SolidColorBrush(Colors.Green);
                return true;
            }
                
            if (cellStates[6] == cellState && cellStates[7] == cellState && cellStates[8] == cellState)
            {
                brushes[6]= new SolidColorBrush(Colors.Green);
                brushes[7]= new SolidColorBrush(Colors.Green);
                brushes[8] = new SolidColorBrush(Colors.Green);
                return true;
            }
            if (cellStates[0] == cellState && cellStates[3] == cellState && cellStates[6] == cellState)
            {
                brushes[0]= new SolidColorBrush(Colors.Green);
                brushes[3] = new SolidColorBrush(Colors.Green);
                brushes[6] = new SolidColorBrush(Colors.Green);
                return true;
            }
            if (cellStates[1] == cellState && cellStates[4] == cellState && cellStates[7] == cellState)
            {
                brushes[1]= new SolidColorBrush(Colors.Green);
                brushes[4]= new SolidColorBrush(Colors.Green);
                brushes[7] = new SolidColorBrush(Colors.Green);
                return true;
            }
            if (cellStates[2] == cellState && cellStates[5] == cellState && cellStates[8] == cellState)
            {
                brushes[2]= new SolidColorBrush(Colors.Green);
                brushes[5]= new SolidColorBrush(Colors.Green);
                brushes[8] = new SolidColorBrush(Colors.Green);
                return true;
            }
            if (cellStates[0] == cellState && cellStates[4] == cellState && cellStates[8] == cellState)
            {
                brushes[0]= new SolidColorBrush(Colors.Green);
                brushes[4] = new SolidColorBrush(Colors.Green);
                brushes[8] = new SolidColorBrush(Colors.Green);
                return true;
            }
            if (cellStates[2] == cellState && cellStates[4] == cellState && cellStates[6] == cellState)
            {
                brushes[2]= new SolidColorBrush(Colors.Green);
                brushes[4]= new SolidColorBrush(Colors.Green);
                brushes[6] = new SolidColorBrush(Colors.Green);
                return true;
            }
            return false;
        }

        private bool IsMetal(string value)
        {
            return Elements.Where(x => x.ElementName == value).Select(x => x.IsCheck).First();
        }


        private void GenerateResult(string winPlayer)
        {
            if (MessageBox.Show("Игра закончена","Результат",MessageBoxButton.OK,MessageBoxImage.Information)== MessageBoxResult.OK)
            {
                NavigateTo(new ResultPage
                {
                    DataContext = new ResultPageViewModel(winPlayer,buttonsContent,brushes)
                });
            }
        }

        #endregion

        #region CreateElements

        private void Mode(GameMode gameMode)
        {
            switch (gameMode)
            {
                case GameMode.MetalAndNotMetal:
                    MetalAndNotMetal();
                    break;
                case GameMode.OxidesAndAcids:
                    OxidesAndAcids();
                    break;
                case GameMode.SaltAndBase:
                    SaltAndBase();
                    break;
            }
        }

        private void MetalAndNotMetal()
        {
            if(Elements ==null)
                Elements = new ObservableCollection<Elements>();
            
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "C",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C2",
                IsCheck = true,
            });
        }
        private void OxidesAndAcids()
        {
            if(Elements ==null)
                Elements = new ObservableCollection<Elements>();
            
            Elements.Add(new Elements
            {
                ElementName = "H12",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "H2341",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "Hsdf2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "M12",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "Msdf1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "M122",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "Csdf",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "1C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "C432",
                IsCheck = true,
            });
        }
        private void SaltAndBase()
        {
            if(Elements ==null)
                Elements = new ObservableCollection<Elements>();
            
            Elements.Add(new Elements
            {
                ElementName = "H112",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "dH21341",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "fHsdf2",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "dM12",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "dMsdf1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "fdM122",
                IsCheck = true,
            });
            
            Elements.Add(new Elements
            {
                ElementName = "dfCsdf",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "df1C1",
                IsCheck = true,
            });
            Elements.Add(new Elements
            {
                ElementName = "dC432",
                IsCheck = true,
            });
        }
        
        
        
        
        #endregion
    }
}