using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Visuals.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SciChartAnnoTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var lineData = new XyDataSeries<DateTime, double>();
            for (int i = 0; i < 1000; i++)
            {
                lineData.Append(DateTime.Now.AddSeconds(i), i);
            }
            LineSeries.DataSeries = lineData;

            AddAnnotation();
            AddAnnotation();
        }

        private void AddAnnotation()
        {
            var label = new MyAnnotationLabel()
            {
                LabelPlacement = LabelPlacement.Auto
            };

            var annotation = new VerticalLineAnnotation()
            {
                Stroke = new SolidColorBrush(Colors.Orange),
                StrokeThickness = 1,
                X1 = DateTime.Now.AddSeconds(100),
                IsEditable = true,
                XAxisId = "XAxis",
                YAxisId = "YAxis",
                AnnotationLabels = { label},
            };

            sliceModifier.VerticalLines.Add(annotation);
        }
    }
}
