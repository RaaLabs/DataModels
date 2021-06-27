// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace RaaLabs.DataModels.MaritimeContext
{
    /// <summary> 
    /// Equipment describe the highest level of sensor hierarcy 
    /// </summary>
    public class EquipmentInstantaneous
    {
        /// <summary> Discipline describe the second level of sensor hierarcy </summary>
        public string Discipline { get; set; }

        /// <summary> Key describe the second and third level of sensor hierarcy on the format secondLvl/thirdLvl </summary>
        public string CommonKey { get; set; }

        /// <summary> LocalKey describe the second and third level of sensor hierarcy on the format secondLvl/thirdLvl </summary>
        public string LocalKey { get; set; }
        
        /// <summary> Instance describe Key on the format x/z </summary>
        public string Instance { get; set; }

        /// <summary> InstanceId describe Instance with a unique identifier </summary>
        public string InstanceId { get; set; }

        /// <summary> Title contains the tag description from MC and other custom schemas </summary>
        public Title Title { get; set; }

        /// <summary> OtherIds contains the schemas of other existing tag descriptions </summary>
        public List<OtherIds> OtherIds { get; set; }

        /// <summary> Reading contains data regarding the reading from the sensor or sensor system </summary>
        public ReadingInstantaneous Reading { get; set; }
    }
}