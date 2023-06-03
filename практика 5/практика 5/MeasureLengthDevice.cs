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
        private Units unitsToUse;
        private int[] dataCaptured;
        private int mostRecentMeasure;
        private DeviceController.DeviceController controller;
        const  DeviceType measurementType = DeviceType.LENGTH;
       
        public MeasureLengthDevice(Units units)
        {
            unitsToUse = units;

        }
        public int[] GetRawData()
        {
            return dataCaptured;
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

        //public void StartCollecting()
        //{
        //    controller = DeviceController.DeviceController.StartDevice(measurementType);
        //    GetMeasurements();
        //}

        //public void StopCollecting()
        //{
        //    if (controller != null)
        //    {
        //        controller.StopDevice();
        //    }
        //}

        //private void GetMeasurements()
        //{
        //    dataCaptured = new int[10];
        //    System.Threading.ThreadPool.QueueUserWorkItem((dummy) =>
        //    {
        //        int x = 0;
        //        Random timer = new Random();

        //        while (controller != null)
        //        {
        //            System.Threading.Thread.Sleep(timer.Next(1000, 5000));
        //            dataCaptured[x] = controller != null ?
        //                controller.TakeMeasurement() : dataCaptured[x];
        //            mostRecentMeasure = dataCaptured[x];
        //            x++;
        //            if (x == 10)
        //            {
        //                x = 0;
        //            }
        //        }
        //    });
        //}

    }
}

