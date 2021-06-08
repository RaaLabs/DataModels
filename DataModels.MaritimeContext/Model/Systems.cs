// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Systems contains metadata relevant to the system generating the data
    /// </summary>
    public class Systems
    {
        /// <summary> Name of the system </summary>
        public string Name { get; set; }

        /// <summary> InternalId of the system </summary>
        public string InternalId { get; set; }   

        /// <summary> Uri the system </summary>
        public string Uri { get; set; }             
    }
}