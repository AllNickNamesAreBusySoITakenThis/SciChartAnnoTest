using SciChart.Charting.ChartModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciChartAnnoTest
{
    public class MySliceModifier: VerticalSliceModifier
    {
        public MySliceModifier()
        {
            this.TooltipPlacement = TooltipPlacement.Left;
        }

        public string TestTextProp { get; set; }
    }
}
