// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Sensor spesific data
    /// </summary>
    public class Sensor
    {
        /// <summary> Id of the sensor </summary>
        public string Id { get; set; }

        /// <summary> Title of the sensor </summary>
        public string Title { get; set; }

        /// <summary> Type  of the sensor </summary>
        public string Type { get; set; }

        /// <summary> Maker of the sensor </summary>
        public string Maker { get; set; }

        /// <summary> Model of the sensor </summary>
        public string Model { get; set; }

        /// <summary> Serial number of the sensor </summary>
        public string SerialNr { get; set; }

        /// <summary> Calibration date of the sensor </summary>
        public string CalibrationDate { get; set; }

    }
}