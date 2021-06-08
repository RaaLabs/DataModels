// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Title contains the tag description from MC and other custom schemas
    /// </summary>
    public class OtherIds
    {
        /// <summary> Name of schema</summary>
        public string Schema { get; set; }

        /// <summary> Version of schema </summary>
        public string Version { get; set; }

        /// <summary> Key to tag in schema </summary>
        public string Key { get; set; }

        /// <summary> Title of tag in schema </summary>
        public string Title { get; set; }
    }
}