namespace RaaLabs.DataModels.MaritimeContext
{
    public class source
    {
        public string sourceKey { get; set; }
        public string sourceType { get; set; }
        public string relativeUrl { get; set; }
        public string systemName { get; set; }
        public customFields customFields { get; set; }
    }
}