using System;
using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class Means
    {
        [JsonPropertyName("uve")]
        public Uve[] Uve { get; set; }
    }
}

