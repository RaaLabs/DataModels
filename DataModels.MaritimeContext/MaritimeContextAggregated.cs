// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Data of the reading
    /// </summary>
    public class MaritimeContextAggregated
    {
        /// <summary>  </summary>
        public Header Header { get; set; }

        /// <summary>  </summary>
        public McBodyAggregated McBodyAggregated { get; set; }
    }
}