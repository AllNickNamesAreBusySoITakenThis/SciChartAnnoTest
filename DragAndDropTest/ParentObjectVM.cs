using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DragAndDropTest
{
    public class ParentObjectVM:ViewModelBase
    {
        Point position;
        public Point Position
        {
            get { return position; }
            set { if (position != value) { position = value; RaisePropertyChanged("Position"); } }
        }

        Point nodePosition;

        public Point NodePosition
        {
            get { return nodePosition; }
            set { if (nodePosition != null) { nodePosition = value; RaisePropertyChanged("NodePosition"); } }
        }

        private ObservableCollection<ObjectVM> children = new ObservableCollection<ObjectVM>();

        public ObservableCollection<ObjectVM> Children
        {
            get { return children; }
            set { children = value; RaisePropertyChanged("Children"); }
        }



        // выставляем команду, которая занимается перемещением
        public ICommand ParentRequestMove
        {
            get { return new RelayCommand<Point>(MoveTo); }
        }

        void MoveTo(Point newPosition)
        {
            // в реальности тут могут быть всякие проверки, конечно
            Position = newPosition;

            NodePosition = new Point(newPosition.X + 30, newPosition.Y + 30);
        }
    }
}
