using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace DomainInfo.Models
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Domain(string Name)
        {
            this.Id = 0;
            this.Name = Name;
        }

        public async Task<DNSRecords> DNSQuery(DNSRecordType Type)
        {
            HttpClient client = new HttpClient();
            // TODO: Validate the name
            var record = new DNSRecord(Type);
            DNSRecords records;
            var URL = $"https://dns.google/resolve?name={this.Name}&type={record.ReadableType()}";
            var TResponse = await client.GetAsync(URL);
            if (TResponse.IsSuccessStatusCode)
            {
                records = JsonSerializer.Deserialize<DNSRecords>(await TResponse.Content.ReadAsStringAsync());
            }
            else records = new DNSRecords();
            record.Parse(await TResponse.Content.ReadAsStringAsync());
            return records;
        }


        public async Task<WhoisRecord> WhoisQuery()
        {
            HttpClient client = new HttpClient();
            // TODO: Validate the name
            var record = new WhoisRecord(this);
            var URL = $"http://maneea.net/api/whois/{this.Name}";
            var TResponse = await client.GetAsync(URL);
            if (TResponse.IsSuccessStatusCode)
            {
                record.Content = await TResponse.Content.ReadAsStringAsync();
            }
            else record.Content = "Could not make the API request. Check the connection at the ASP.NET hosting server";
            return record;
        }
    }
}