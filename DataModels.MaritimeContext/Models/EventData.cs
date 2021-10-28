namespace RaaLabs.DataModels.MaritimeContext
{
    public class eventData
    {
        public string mcKey { get; set; }
        public string discipline { get; set; }
        public string eventType { get; set; }
        public string timestampUTC { get; set; }
        public string timestampLocal { get; set; }
        public string id { get; set; }
    }
}