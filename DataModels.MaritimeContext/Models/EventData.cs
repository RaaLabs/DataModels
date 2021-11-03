namespace RaaLabs.DataModels.MaritimeContext
{
    public class EventData
    {
        public string McKey { get; set; }
        public string Discipline { get; set; }
        public string EventType { get; set; }
        public string TimestampUTC { get; set; }
        public string TimestampLocal { get; set; }
        public string Id { get; set; }
    }
}