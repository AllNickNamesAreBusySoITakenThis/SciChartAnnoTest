using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DragAndDropTest
{
    public class ObjectVM : ViewModelBase
    {
        public ObjectVM()
        {

        }
        // стандартное свойство
        Point position;
        public Point Position
        {
            get { return position; }
            set { if (position != value) { position = value; RaisePropertyChanged("Position"); } }
        }

        // выставляем команду, которая занимается перемещением
        public ICommand RequestMove
        {
            get { return new RelayCommand<Point>(MoveTo); }
        }

        void MoveTo(Point newPosition)
        {
            // в реальности тут могут быть всякие проверки, конечно
            Position = newPosition;
        }   
    }
}
