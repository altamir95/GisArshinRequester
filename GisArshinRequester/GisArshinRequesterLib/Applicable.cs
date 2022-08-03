using System;
using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class Applicable
    {
        [JsonPropertyName("certNum")]
        public string CertNum { get; set; }

        [JsonPropertyName("signPass")]
        public bool SignPass { get; set; }

        [JsonPropertyName("signMi")]
        public bool SignMi { get; set; }
    }
}

