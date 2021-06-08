// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Data of the reading
    /// </summary>
    public class AggregatedData
    {
        /// <summary> Start time of aggregation </summary>
        public string FromTime { get; set; }

        /// <summary> Duration in seconds of aggregation </summary>
        public string TimeFrameSec { get; set; }

        /// <summary> Average of values over the time frame spesified </summary>
        public Average Average { get; set; }

        /// <summary> Median of values over the time frame spesified </summary>
        public Median Median { get; set; }

        /// <summary> Min of values over the time frame spesified </summary>
        public Min Min { get; set; }

        /// <summary> Max of values over the time frame spesified </summary>
        public Max Max { get; set; }

        /// <summary> Standard deviation of values over the time frame spesified </summary>
        public Std Std { get; set; }
    }
}