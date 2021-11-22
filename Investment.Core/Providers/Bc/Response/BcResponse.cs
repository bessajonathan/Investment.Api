using Newtonsoft.Json;

namespace Investment.Core.Providers.Bc.Response
{
    public class BcResponse
    {
        [JsonProperty(PropertyName = "firebaseId")]
        public string FirebaseId { get; set; }
        [JsonProperty(PropertyName = "event")]
        public string Event { get; set; }
        [JsonProperty(PropertyName = "target")]
        public Target Target { get; set; }
        [JsonProperty(PropertyName = "origin")]
        public Origin  Origin { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
    }

    public class Target
    {
        [JsonProperty(PropertyName = "bank")]
        public int Bank { get; set; }
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }
    }

    public class Origin
    {
        [JsonProperty(PropertyName = "bank")]
        public int Bank { get; set; }
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }
        [JsonProperty(PropertyName = "cpf")]
        public string Cpf { get; set; }
    }
}
