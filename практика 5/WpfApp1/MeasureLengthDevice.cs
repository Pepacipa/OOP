using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceController;
using практика_5.MeasuringDevice;

namespace практика_5
{
    public class MeasureLengthDevice : MeasureDataDevice
    {
       
        public MeasureLengthDevice(Units units)
        {
            unitsToUse = units;
            measurementType = DeviceType.LENGTH;
        }


        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial)
            {
                return mostRecentMeasure;
            }
            else 
                return mostRecentMeasure * (decimal)0.03937;
        }

        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric)
            {
                return mostRecentMeasure;
            }
            else 
                return mostRecentMeasure * (decimal)25.4;
        }
    }
}

