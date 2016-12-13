using OxyPlot;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotCS
{
    public class PlotModelDefine
    {
        public static PlotModel ZeroCrossing()
        {
            var plotModel = new PlotModel();
            plotModel.PlotAreaBorderThickness = new OxyThickness(0.0);
            plotModel.PlotAreaBorderThickness = new OxyThickness(10);
            var linearAxis = new LinearAxis();
            linearAxis.Maximum = 40;
            linearAxis.Minimum = -40;
            linearAxis.PositionAtZeroCrossing = true;
            linearAxis.TickStyle = TickStyle.Crossing;
            plotModel.Axes.Add(linearAxis);

            var secondLinearAxis = new LinearAxis();
            secondLinearAxis.Maximum = 40;
            secondLinearAxis.Minimum = -40;
            secondLinearAxis.PositionAtZeroCrossing = true;
            secondLinearAxis.TickStyle = TickStyle.Crossing;
            plotModel.Axes.Add(secondLinearAxis);
            return plotModel;
        }
    }
}
