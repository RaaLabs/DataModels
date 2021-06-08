// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Metadata relevant to the event
    /// </summary>
    public class MetaData
    {
        /// <summary> Data channel type desribe how the data is generated, e.g. automatic or manual </summary>
        public string DataChannelType { get; set; }

        /// <summary> Source type describes the unit generating the data, e.g. sensor or application </summary>
        public string SourceType { get; set; }

        /// <summary> Source describe the origin on the data</summary>
        public string Source { get; set; }

        /// <summary> Systems contains metadata relevant to the system generating the data </summary>
        public Systems Systems { get; set; }        

        /// <summary> Sourcedata contains metadata relevent to the sensor generating the data </summary>
        public SourceData SourceData { get; set; }        

    }
}