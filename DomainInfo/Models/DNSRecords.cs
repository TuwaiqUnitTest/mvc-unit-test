using System.Text.Json.Serialization;
namespace DomainInfo.Models
{
    public class DNSRecords
    {
        [JsonPropertyName("Answer")]
        public DNSRecord[] Records { get; set; }
    }
}