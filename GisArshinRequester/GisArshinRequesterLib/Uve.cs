using System;
using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class Uve
    {
        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("uveURL")]
        public Uri UveUrl { get; set; }
    }
}

