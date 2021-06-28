// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Data of the reading
    /// </summary>
    public class Data
    {
        /// <summary> Value of the reading </summary>
        public dynamic Value { get; set; }

        /// <summary> Unit of the reading </summary>
        public string Unit { get; set; }

        public Title Title { get; set; }
    }
}