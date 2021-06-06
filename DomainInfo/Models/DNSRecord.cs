using System;
using System.Text.Json.Serialization;
namespace DomainInfo.Models
{
    public class DNSRecord
    {
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Domain { get; set; }

        [JsonPropertyName("TTL")]
        public int TTL { get; set; }

        [JsonPropertyName("type")]
        public DNSRecordType Type { get; set; }

        [JsonPropertyName("data")]
        public string Content { get; set; }

        public DNSRecord(DNSRecordType Type)
        {
            this.Type = Type;
        }
        public DNSRecord()
        {

        }

        public string ReadableType()
        {
            return Enum.GetName(typeof(DNSRecordType), this.Type);
        }

        public void Parse(string json) { }

    }

    public enum DNSRecordType
    {
        A = 1,
        NS = 2,
        CNAME = 5,
        SOA = 6,
        PTR = 12,
        HINFO = 13,
        MX = 15,
        TXT = 16,
        RP = 17,
        AFSDB = 18,
        SIG = 24,
        KEY = 25,
        AAAA = 28,
        LOC = 29,
        SRV = 33,
        NAPTR = 35,
        KX = 36,
        CERT = 37,
        DNAME = 39,
        APL = 42,
        DS = 43,
        SSHFP = 44,
        IPSECKEY = 45,
        RRSIG = 46,
        NSEC = 47,
        DNSKEY = 48,
        DHCID = 49,
        NSEC3 = 50,
        NSEC3PARAM = 51,
        TLSA = 52,
        SMIMEA = 53,
        HIP = 55,
        CDS = 59,
        CDNSKEY = 60,
        OPENPGPKEY = 61,
        CSYNC = 62,
        ZONEMD = 63,
        SVCB = 64,
        HTTPS = 65,
        EUI48 = 108,
        EUI64 = 109,
        TKEY = 249,
        TSIG = 250,
        URI = 256,
        CAA = 257,
        TA = 32768,
        DLV = 32769,
        ALL = 255,
        AXFR = 252,
        IXFR = 251,
        OPT = 41,
        MD = 3,
        MF = 4,
        MAILA = 254,
        MB = 7,
        MG = 8,
        MR = 9,
        MINFO = 14,
        MAILB = 253,
        WKS = 11,
        NB = 32,
        NBSTAT = 33,
        NULL = 10,
        A6 = 38,
        NXT = 30,
        X25 = 19,
        ISDN = 20,
        RT = 21,
        NSAP = 22,
        NSAPPTR = 23,
        PX = 26,
        EID = 31,
        NIMLOC = 32,
        ATMA = 34,
        SINK = 40,
        GPOS = 27,
        UINFO = 100,
        UID = 101,
        GID = 102,
        UNSPEC = 103,
        SPF = 99,
        NINFO = 56,
        RKEY = 57,
        TALINK = 58,
        NID = 104,
        L32 = 105,
        L64 = 106,
        LP = 107,
        DOA = 259,
    }
}