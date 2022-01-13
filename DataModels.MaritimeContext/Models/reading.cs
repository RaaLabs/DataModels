using System.Collections.Generic;

namespace RaaLabs.DataModels.MaritimeContext
{
    public class Reading
    {
        public string Content { get; set; }
        public string Position { get; set; }
        public string Measure { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReadingTime { get; set; }
        public string ReadingType { get; set; }
        public double IntervalSeconds { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public List<CustomFields> CustomFields { get; set; }
    }
}