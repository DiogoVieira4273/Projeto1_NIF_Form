using System.Text.Json.Serialization;

namespace Projeto1_NIF_Form
{
    public class Root
    {
        [JsonPropertyName("Result")]
        public string Result { get; set; }
        [JsonPropertyName("Records")]
        public Records Records { get; set; }
        [JsonPropertyName("Nif_validation")]
        public bool Nif_validation { get; set; }
        [JsonPropertyName("Is_nif")]
        public bool Is_nif { get; set; }
        [JsonPropertyName("Credits")]
        public Credits Credits { get; set; }
    }

    public class Records
    {
        [JsonPropertyName("NIF")]
        public NIF NIF { get; set; }
    }

    public class NIF
    {
        [JsonPropertyName("Nif")]
        public int Nif { get; set; }
        [JsonPropertyName("Seo_url")]
        public string Seo_url { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [JsonPropertyName("Pc4")]
        public string Pc4 { get; set; }
        [JsonPropertyName("Pc3")]
        public string Pc3 { get; set; }
        [JsonPropertyName("City")]
        public string City { get; set; }
        [JsonPropertyName("Start_date")]
        public object Start_date { get; set; }
        [JsonPropertyName("Activity")]
        public object Activity { get; set; }
        [JsonPropertyName("Status")]
        public string Status { get; set; }
        [JsonPropertyName("Cae")]
        public string Cae { get; set; }
        [
            JsonPropertyName("Contacts")]
        public Contacts Contacts { get; set; }
        [JsonPropertyName("Structure")]
        public Structure Structure { get; set; }
        [JsonPropertyName("Geo")]
        public Geo Geo { get; set; }
        [JsonPropertyName("Place")]
        public Place Place { get; set; }
        [JsonPropertyName("Racius")]
        public string Racius { get; set; }
        [JsonPropertyName("Alias")]
        public string Alias { get; set; }
        [JsonPropertyName("Portugalio")]
        public string Portugalio { get; set; }
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
        [JsonPropertyName("Nature")]
        public object Nature { get; set; }
        [JsonPropertyName("Capital")]
        public object Capital { get; set; }
        [JsonPropertyName("Capital_currency")]
        public object Capital_currency { get; set; }
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
        [JsonPropertyName("Used")]
        public string Used { get; set; }
        [JsonPropertyName("Left")]
        public Left Left { get; set; }
    }

    public class Left
    {
        [JsonPropertyName("Month")]
        public int Month { get; set; }
        [JsonPropertyName("Day")]
        public int Day { get; set; }
        [JsonPropertyName("Hour")]
        public int Hour { get; set; }
        [JsonPropertyName("Minute")]
        public int Minute { get; set; }
        [JsonPropertyName("Paid")]
        public int Paid { get; set; }
    }
}