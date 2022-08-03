using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    /// <summary>Результат запроса</summary>
    public class VriResult<T>
    {
        /// <summary>Количество найденных по запросу элементов</summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>Номер начальной записи в выборке</summary>
        [JsonPropertyName("start")]
        public int Start { get; set; }

        /// <summary>Количество строк на странице</summary>
        [JsonPropertyName("rows")]
        public int Rows { get; set; }

        /// <summary>Массив найденных по запросу элементов</summary>
        [JsonPropertyName("items")]
        public List<T> Items { get; set; }
    }
}

