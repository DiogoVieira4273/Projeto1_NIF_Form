using System.Text.Json.Serialization;

namespace Projeto1_NIF_Form
{
    public class Root
    {
        [JsonPropertyName("result")]
        public string result { get; set; }
        [JsonPropertyName("Records")]
        public Records Records { get; set; }
        [JsonPropertyName("nif_validation")]
        public bool nif_validation { get; set; }
        [JsonPropertyName("is_nif")]
        public bool is_nif { get; set; }
        [JsonPropertyName("credits")]
        public Credits credits { get; set; }
    }

    public class Records
    {
        public NIF NIF { get; set; }
    }

    public class NIF
    {
        [JsonPropertyName("NIF")]
        public int Nif { get; set; }
        [JsonPropertyName("seo_url")]
        public string seo_url { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [JsonPropertyName("Pc4")]
        public string Pc4 { get; set; }
        [JsonPropertyName("Pc3")]
        public string Pc3 { get; set; }
        [JsonPropertyName("city")]
        public string city { get; set; }
        [JsonPropertyName("start_date")]
        public string start_date { get; set; }
        [JsonPropertyName("activity")]
        public string activity { get; set; }
        [JsonPropertyName("status")]
        public string status { get; set; }
        [JsonPropertyName("cae")]
        public string[] cae { get; set; }
        [JsonPropertyName("Contacts")]
        public Contacts Contacts { get; set; }
        [JsonPropertyName("structure")]
        public Structure structure { get; set; }
        [JsonPropertyName("Geo")]
        public Geo Geo { get; set; }
        [JsonPropertyName("Place")]
        public Place Place { get; set; }
        [JsonPropertyName("racius")]
        public string racius { get; set; }
        [JsonPropertyName("alias")]
        public string alias { get; set; }
        [JsonPropertyName("portugalio")]
        public string portugalio { get; set; }
    }

    public class Contacts
    {
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }
        [JsonPropertyName("Website")]
        public string Website { get; set; }
        [JsonPropertyName("Fax")]
        public string Fax { get; set; }
    }

    public class Structure
    {
        [JsonPropertyName("nature")]
        public string nature { get; set; }
        [JsonPropertyName("capital")]
        public string capital { get; set; }
        [JsonPropertyName("capital_currency")]
        public string capital_currency { get; set; }
    }

    public class Geo
    {
        [JsonPropertyName("Region")]
        public string Region { get; set; }
        [JsonPropertyName("County")]
        public string County { get; set; }
        [JsonPropertyName("Parish")]
        public string Parish { get; set; }
    }

    public class Place
    {
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [JsonPropertyName("Pc4")]
        public string Pc4 { get; set; }
        [JsonPropertyName("Pc3")]
        public string Pc3 { get; set; }
        [JsonPropertyName("City")]
        public string City { get; set; }
    }

    public class Credits
    {
        [JsonPropertyName("used")]
        public string used { get; set; }
        [JsonPropertyName("left")]
        public object[] left { get; set; }
    }
}