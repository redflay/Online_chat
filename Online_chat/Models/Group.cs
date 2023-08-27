public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<User> Users { get; set; }

    public virtual ICollection<Message> Messages { get; set; }
}