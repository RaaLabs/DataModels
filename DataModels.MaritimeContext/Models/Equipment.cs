using System.Collections.Generic;

namespace RaaLabs.DataModels.MaritimeContext
{
    public class Equipment
    {
        public string Key { get; set; }
        public string Title { get; set; }
        public List<CustomFields> CustomFields { get; set; }

    }
}