using System.Collections.Generic;

namespace RaaLabs.DataModels.MaritimeContext
{
    public class VesselReading
    {
        public string Content { get; set; }
        public string Measure { get; set; }
        public string PositionLongitudinal { get; set; }
        public string PositionTransverse { get; set; }
        public dynamic Value { get; set; }
        public string Unit { get; set; }
        public string Timestamp { get; set; }
        public string Title { get; set; }
    }
}