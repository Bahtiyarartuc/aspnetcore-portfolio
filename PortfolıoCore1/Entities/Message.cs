namespace PortfolıoCore1.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public int NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
       
    }
}
