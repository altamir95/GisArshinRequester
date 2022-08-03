using System;
using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class VriInfo
    {
        [JsonPropertyName("organization")]
        public string Organization { get; set; }

        [JsonPropertyName("signCipher")]
        public string SignCipher { get; set; }

        [JsonPropertyName("vrfDate")]
        public string VrfDate { get; set; }

        [JsonPropertyName("validDate")]
        public string ValidDate { get; set; }

        [JsonPropertyName("docTitle")]
        public string DocTitle { get; set; }

        [JsonPropertyName("applicable")]
        public Applicable Applicable { get; set; }
    }
}

