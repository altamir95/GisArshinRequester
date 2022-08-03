using System;
using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class MiInfo
    {
        [JsonPropertyName("singleMI")]
        public SingleMi SingleMi { get; set; }
    }
}

