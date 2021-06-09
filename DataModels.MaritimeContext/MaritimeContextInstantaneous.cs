// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Data of the reading
    /// </summary>
    public class MaritimeContextInstantaneous
    {
        /// <summary> Header section of the event </summary>
        public Header Header { get; set; }

        /// <summary> Body section of the event </summary>
        public McBodyInstantaneous Body { get; set; }
    }
}