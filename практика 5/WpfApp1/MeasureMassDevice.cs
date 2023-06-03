using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using практика_5.MeasuringDevice;
using DeviceController;

namespace практика_5
{
    internal class MeasureMassDevice : MeasureDataDevice
    {

        public MeasureMassDevice(Units units)
        {
            unitsToUse = units;
            measurementType = DeviceType.MASS;

        }

        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial)
            {
                return mostRecentMeasure;
            }
            else
                return mostRecentMeasure * (decimal)2.2046;
        }

        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric)
            {
                return mostRecentMeasure;
            }
            else
                return mostRecentMeasure * (decimal)0.4536;
        }
    }
}
