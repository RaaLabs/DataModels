// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Title contains the tag description from MC and other custom schemas
    /// </summary>
    public class Title
    {
        /// <summary> Mc tag description </summary>
        public string Mc { get; set; }

        /// <summary> Custom tag description</summary>
        public string Custom { get; set; }
    }
}