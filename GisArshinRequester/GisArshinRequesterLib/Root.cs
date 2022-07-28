using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    public class Root<T>
    {
        /// <summary>Результат запроса</summary>
        [JsonPropertyName("result")]
        public Result<T> Result { get; set; }
    }
}

