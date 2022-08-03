using System;
using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class VriByIdResult
    {
        [JsonPropertyName("miInfo")]
        public MiInfo MiInfo { get; set; }

        [JsonPropertyName("vriInfo")]
        public VriInfo VriInfo { get; set; }

        [JsonPropertyName("means")]
        public Means Means { get; set; }
    }
}

