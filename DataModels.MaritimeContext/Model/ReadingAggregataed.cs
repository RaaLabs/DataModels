// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Reading contains data regarding the reading from the sensor or sensor system
    /// </summary>
    public class ReadingAggregated
    {
        /// <summary> Time when the event was received on Edge and assigned a timestamp </summary>
        public string Time { get; set; }

        /// <summary> Content of the reading </summary>
        public string Content { get; set; }

        /// <summary> Quantity of the reading </summary>
        public string Quantity { get; set; }

        /// <summary> Position of the reading </summary>
        public string Position { get; set; }

        /// <summary> Data of the reading </summary>
        public AggregatedData Data { get; set; }
    }
}