// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Event spesific data
    /// </summary>
    public class Event
    {
        /// <summary> EventType describe if the event is an instentainous or aggregated event.  </summary>
        public string EventType { get; set; }

        /// <summary> EventVersion describe the version of the event format  </summary>
        public string EventVersion { get; set; }

        /// <summary> Unique event id  </summary>
        public string Id { get; set; }

        /// <summary> Timestamp UTC  </summary>
        public string TimestampUTC { get; set; }
        
        /// <summary> Timestamp local  </summary>
        public string TimestampLocal { get; set; }
    }
}