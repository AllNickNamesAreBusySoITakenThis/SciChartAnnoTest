using SciChart.Charting.Visuals.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SciChartAnnoTest
{
    /// <summary>
    /// Своя метка времени для вертикальных линий
    /// </summary>
    public class MyAnnotationLabel: AnnotationLabel
    {
        public MyAnnotationLabel()
        {
            RotationAngle = 30;
        }

        /// <summary>
        /// Переопредели двойной клик по метке времени. Теперь она меняет положение
        /// (из установленных вариантов) при двойном клике
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
        {
            var values = Enum.GetValues(typeof(LabelPlacement));
            var curPos = (int)LabelPlacement;
            curPos++;
            if (curPos== values.Length)
            {
                curPos = 0;
            }
            LabelPlacement = (LabelPlacement)curPos;
        }

        protected override void OnDragEnter(DragEventArgs e)
        {
            //base.OnDragEnter(e);
        }
    }
}
