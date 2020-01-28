using Caliburn.Micro;
using System.ComponentModel;
using System.Windows;

namespace ChessHorse.ViewModels
{
    public class ShellViewModel : Screen
    {

        public class ChessPieces : INotifyPropertyChangedEx
        {
            public ChessPieces()
            {

            }

            public enum ChessItemsType
            {
                WhitePawn,
                WhiteRook,
                WhiteKnight,
                WhiteBishop,
                WhiteQueen,
                WhiteKing,
                BlackPawn,
                BlackRook,
                BlackKnight,
                BlackBishop,
                BlackQueen,
                BlackKing,
            }

            private ChessItemsType _Type = ChessItemsType.WhitePawn;
            public ChessItemsType Type
            {
                get { return _Type; }
                set
                {
                    NotifyOfPropertyChange(nameof(Type));
                    _Type = value;


                }
            }

            private Point _Pos;

            public event PropertyChangedEventHandler PropertyChanged;

            public Point Pos
            {
                get { return _Pos; }
                set 
                {
                    _Pos = value; 
                    //NotifyOfPropertyChange(() => Pos);
                }
            }

            public bool IsNotifying { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

            public void NotifyOfPropertyChange(string propertyName)
            {
                var propValue = this.GetType().GetProperty(propertyName).GetValue(this);
                this.PropertyChanged?.Invoke(propValue, new PropertyChangedEventArgs(propertyName));
            }

            public void Refresh()
            {
                throw new System.NotImplementedException();
            }
        }
        public BindableCollection<ChessPieces> ChessBoardControl { get; set; }

        public ShellViewModel()
        {
            ChessBoardControl = new BindableCollection<ChessPieces>()
           { new ChessPieces  {Pos = new Point(0, 6), Type = ChessPieces.ChessItemsType.WhitePawn } };
            /* new ShellViewModel { Pos = new Point(1, 6), Type = ChessItemsType.WhitePawn },
            new ShellViewModel { Pos = new Point(2, 6), Type = ChessItemsType.WhitePawn },
            new ShellViewModel { Pos = new Point(3, 6), Type = ChessItemsType.WhitePawn },
            new ShellViewModel { Pos = new Point(4, 6), Type = ChessItemsType.WhitePawn },
            new ShellViewModel { Pos = new Point(5, 6), Type = ChessItemsType.WhitePawn },
             new ShellViewModel { Pos = new Point(6, 6), Type = ChessItemsType.WhitePawn },
            new ShellViewModel { Pos = new Point(7, 6), Type = ChessItemsType.WhitePawn },
            new ShellViewModel { Pos = new Point(0, 7), Type = ChessItemsType.WhiteRook },
            new ShellViewModel { Pos = new Point(1, 7), Type = ChessItemsType.WhiteKnight },
            new ShellViewModel { Pos = new Point(2, 7), Type = ChessItemsType.WhiteBishop },
            new ShellViewModel { Pos = new Point(3, 7), Type = ChessItemsType.WhiteKing },
            new ShellViewModel { Pos = new Point(4, 7), Type = ChessItemsType.WhiteQueen },
            new ShellViewModel { Pos = new Point(5, 7), Type = ChessItemsType.WhiteBishop },
            new ShellViewModel { Pos = new Point(6, 7), Type = ChessItemsType.WhiteKnight },
             new ShellViewModel { Pos = new Point(7, 7), Type = ChessItemsType.WhiteRook },
             new ShellViewModel { Pos = new Point(0, 1), Type = ChessItemsType.BlackPawn },
            new ShellViewModel { Pos = new Point(1, 1), Type = ChessItemsType.BlackPawn },
            new ShellViewModel { Pos = new Point(2, 1), Type = ChessItemsType.BlackPawn },
             new ShellViewModel { Pos = new Point(3, 1), Type = ChessItemsType.BlackPawn },
             new ShellViewModel { Pos = new Point(4, 1), Type = ChessItemsType.BlackPawn },
            new ShellViewModel { Pos = new Point(5, 1), Type = ChessItemsType.BlackPawn },
            new ShellViewModel { Pos = new Point(6, 1), Type = ChessItemsType.BlackPawn },
             new ShellViewModel { Pos = new Point(7, 1), Type = ChessItemsType.BlackPawn },
            new ShellViewModel { Pos = new Point(0, 0), Type = ChessItemsType.BlackRook },
            new ShellViewModel { Pos = new Point(1, 0), Type = ChessItemsType.BlackKnight },
            new ShellViewModel { Pos = new Point(2, 0), Type = ChessItemsType.BlackBishop },
            new ShellViewModel { Pos = new Point(3, 0), Type = ChessItemsType.BlackKing },
            new ShellViewModel { Pos = new Point(4, 0), Type = ChessItemsType.BlackQueen },
            new ShellViewModel { Pos = new Point(5, 0), Type = ChessItemsType.BlackBishop },
            new ShellViewModel { Pos = new Point(6, 0), Type = ChessItemsType.BlackKnight },
            new ShellViewModel { Pos = new Point(7, 0), Type = ChessItemsType.BlackRook },
             };*/
        }
        private int _test = 0;
        public int Test { get => _test; set
            {

                NotifyOfPropertyChange(() => Test);
            }
        }
    }
    
    
}

    
    

