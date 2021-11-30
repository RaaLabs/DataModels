namespace RaaLabs.DataModels.MaritimeContext
{
    public class Source
    {
        public string SourceKey { get; set; }
        public string SourceType { get; set; }
        public string RelativeUrl { get; set; }
        public string SystemName { get; set; }
        public CustomFields CustomFields { get; set; }
    }
}