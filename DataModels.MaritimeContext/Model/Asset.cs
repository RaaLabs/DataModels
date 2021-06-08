// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Asset spesific data
    /// </summary>
    public class Asset
    {
        /// <summary> Name of the asset </summary>
        public string Name { get; set; }

        /// <summary> Unique ID of the asset </summary>
        public string GlobalId { get; set; }
    }
}