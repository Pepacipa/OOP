using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceController;

namespace практика_5
{
    namespace MeasuringDevice
    {
        public abstract class MeasureDataDevice : IMeasuringDevice
        {
            private Units unitsToUse;
            private int[] dataCaptured;
            public int mostRecentMeasure;
            private DeviceController.DeviceController controller;
            private DeviceType measurementType;
            /// <summary>
            /// Converts the raw data collected by the measuring device into a metric value.
            /// </summary>
            /// <returns>The latest measurement from the device converted to metric units.</returns>
            public abstract decimal MetricValue();
            /// <summary>
            /// Converts the raw data collected by the measuring device into an imperial value.
            /// </summary>
            ///<returns>The latest measurement from the device converted to imperial units.</returns>
            public abstract decimal ImperialValue();
            /// <summary>
            /// Starts the measuring device.
            /// </summary>
            public void StartCollecting()
            {
                controller = DeviceController.DeviceController.StartDevice(measurementType);
                GetMeasurements();
            }
            /// <summary>
            /// Stops the measuring device.
            /// </summary>
            public void StopCollecting()
            {
                if (controller != null)
                {
                    controller.StopDevice();
                }
            }

            public int[] GetRawData()
            {
                return dataCaptured;
            }

            private void GetMeasurements()
            {
                dataCaptured = new int[10];
                System.Threading.ThreadPool.QueueUserWorkItem((dummy) =>
                {
                    int x = 0;
                    Random timer = new Random();

                    while (controller != null)
                    {
                        System.Threading.Thread.Sleep(timer.Next(1000, 5000));
                        dataCaptured[x] = controller != null ?
                            controller.TakeMeasurement() : dataCaptured[x];
                        mostRecentMeasure = dataCaptured[x];
                        x++;
                        if (x == 10)
                        {
                            x = 0;
                        }
                    }
                });

            }
        }
    }
}
