using System.Text.Json.Serialization;

namespace GisArshinRequesterLib
{
    /// <summary>Сведение о результате поверки СИ</summary>
    public class SiVerificationInfoResult
    {
        /// <summary>Идентификатор элемента</summary>
        [JsonPropertyName("vri_id")]
        public string Id { get; set; }

        /// <summary>Наименование организации-поверителя</summary>
        [JsonPropertyName("org_title")]
        public string OrgName { get; set; }

        /// <summary>Регистрационный номер типа СИ</summary>
        [JsonPropertyName("mit_number")]
        public string RegistrationNumber { get; set; }

        /// <summary>Наименование типа СИ</summary>
        [JsonPropertyName("mit_title")]
        public string TypeName { get; set; }

        /// <summary>Обозначение типа СИ</summary>
        [JsonPropertyName("mit_notation")]
        public string TypeNotation { get; set; }

        /// <summary>Модификация СИ</summary>
        [JsonPropertyName("mi_modification")]
        public string Modification { get; set; }

        /// <summary>Заводской/серийный номер/буквенноцифровое обозначение</summary>
        [JsonPropertyName("mi_number")]
        public string Number { get; set; }

        /// <summary>Дата поверки</summary>
        [JsonPropertyName("verification_date")]
        public string VerificationDate { get; set; }

        /// <summary>Действительна до</summary>
        [JsonPropertyName("valid_date")]
        public string ValidDate { get; set; }

        /// <summary>Номер свидетельства/извещения/выписки</summary>
        [JsonPropertyName("result_docnum")]
        public string DocumentNumber { get; set; }

        /// <summary>Пригодность</summary>
        [JsonPropertyName("applicability")]
        public bool Applicability { get; set; }
    }
}

