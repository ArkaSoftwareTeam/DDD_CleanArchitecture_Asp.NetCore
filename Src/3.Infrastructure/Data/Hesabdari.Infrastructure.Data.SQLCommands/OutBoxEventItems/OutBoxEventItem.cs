namespace Hesabdari.Infrastructure.Data.SQLCommands.OutBoxEventItems
{
    public class OutBoxEventItem
    {
        public long OutBoxEventItemId { get; set; }
        public Guid EventId { get; set; }
        public string AccuredByUserId { get; set; } = string.Empty;
        public DateTime AccuredOn { get; set; }
        public string AggregateName { get; set; } = string.Empty;
        public string AggregateTypeName { get; set; } = string.Empty;
        public string AggregateId { get; set; } = string.Empty;
        public string EventName { get; set; } = string.Empty;
        public string EventTypeName { get; set; } = string.Empty;
        public string EventPayload { get; set; } = string.Empty;
        public bool IsProcessed { get; set; }
    }
}
