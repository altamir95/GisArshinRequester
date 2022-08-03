using System;
using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class SingleMi
    {
        [JsonPropertyName("mitypeNumber")]
        public string MitypeNumber { get; set; }

        [JsonPropertyName("mitypeURL")]
        public string MitypeUrl { get; set; }

        [JsonPropertyName("mitypeType")]
        public string MitypeType { get; set; }

        [JsonPropertyName("mitypeTitle")]
        public string MitypeTitle { get; set; }

        [JsonPropertyName("manufactureNum")]
        public string ManufactureNum { get; set; }

        [JsonPropertyName("modification")]
        public string Modification { get; set; }
    }
}

