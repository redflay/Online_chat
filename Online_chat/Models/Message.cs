public class Message
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public int SenderId { get; set; }
    public int? ReplyToId { get; set; }
    public bool IsPrivate { get; set; }

    public virtual User Sender { get; set; }
    public virtual Message ReplyToMessage { get; set; }
}