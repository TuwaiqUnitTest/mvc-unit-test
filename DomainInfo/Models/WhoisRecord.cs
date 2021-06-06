namespace DomainInfo.Models
{
    public class WhoisRecord
    {
        public int Id { get; set; }
        public Domain Domain { get; set; }
        public string Content { get; set; }

        public WhoisRecord(Domain Domain)
        {
            this.Domain = Domain;
        }
    }
}