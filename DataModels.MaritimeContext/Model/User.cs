// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// User spesific data 
    /// </summary>
    public class User
    {
        /// <summary> Position of the user producing the data </summary>
        public string Position { get; set; }

        /// <summary> Maritime Context unique ID of the user </summary>
        public string McUid { get; set; }
       
        /// <summary> Name of the user producing the data </summary>
        public string Name { get; set; }       
    }
}