// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// The body of an outgoing MC Event
    /// </summary>
    public class McBodyInstantaneous
    {
        /// <summary> Topic is the key to which one subscribe to events. </summary>
        public string Topic { get; set; }

        /// <summary> EventType describe if the event is an instentainous or aggregated event.  </summary>
        public string EventType { get; set; }

        /// <summary> EventVersion describe the version of the event format  </summary>
        public string EventVersion { get; set; }

        /// <summary> Payload contain the equipment readings in the event  </summary>
        public EquipmentInstantaneous Equipment { get; set; }
    }
}