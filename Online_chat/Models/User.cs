public class User
{
    public int Id { get; set; }
    public string Username { get; set; }

    public virtual ICollection<Message> PrivateMessagesSent { get; set; }
    public virtual ICollection<Message> PrivateMessagesReceived { get; set; }
    public virtual ICollection<Group> Groups { get; set; }
}