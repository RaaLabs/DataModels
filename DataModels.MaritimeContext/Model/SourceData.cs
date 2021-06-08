// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Sourcedata contains metadata relevent to the sensor generating the data
    /// </summary>
    public class SourceData
    {
        /// <summary> Sensor spesific data </summary>
        public Sensor Sensor { get; set; }

        /// <summary> User spesific data </summary>
        public User User { get; set; }        

    }
}