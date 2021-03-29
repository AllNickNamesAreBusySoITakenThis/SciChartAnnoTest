using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DragAndDropTest
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ObjectVM> Squares { get; } =
        new ObservableCollection<ObjectVM>()
        {
            new ObjectVM() { Position = new Point( 30,  30) },
            new ObjectVM() { Position = new Point(100,  70) },
            new ObjectVM() { Position = new Point( 80,   0) },
            new ObjectVM() { Position = new Point( 90, 180) },
            new ObjectVM() { Position = new Point(200, 200) }
        };

        public ObservableCollection<ParentObjectVM> Parents { get; } =
        new ObservableCollection<ParentObjectVM>()
        {
            new ParentObjectVM
            { 
                Position = new Point( 10,  30), NodePosition = new Point(40,60), Children = new ObservableCollection<ObjectVM>()
                {
                    new ObjectVM() { Position = new Point( 30,  30) },
                    new ObjectVM() { Position = new Point(100,  70) },
                    new ObjectVM() { Position = new Point( 80,   0) },
                }
            }
        };
    }
}
