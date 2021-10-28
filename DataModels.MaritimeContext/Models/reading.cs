namespace RaaLabs.DataModels.MaritimeContext
{
    public class reading
    {
        public string content { get; set; }
        public string position { get; set; }
        public string measure { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string readingTime { get; set; }
        public string readingType { get; set; }
        public double intervalSeconds { get; set; }
        public double value { get; set; }
        public string unit { get; set; }
        public customFields customFields { get; set; }
    }
}