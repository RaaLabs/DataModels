// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Header of the event
    /// </summary>
    public class Header
    {
        /// <summary> Topic is the key to which one subscribe to events. </summary>
        public string Topic { get; set; }

        /// <summary> Asset spesific data </summary>
        public Asset Asset { get; set; }

        /// <summary> Event spesific data </summary>
        public Event Event {get; set; }

        /// <summary> Metadata relevant to the event </summary>
        public MetaData MetaData {get; set; }

    }
}