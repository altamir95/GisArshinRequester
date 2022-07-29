// https://fgis.gost.ru/fundmetrology/eapi/vri?year=2020&start=5&rows=20
using System.Net.Http.Json;

namespace GisArshinRequesterLib
{
    public class InformationRegisterAboutSiVerificationResults
    {
        public string UrlScheme = "https://";
        public string UrlHost = "fgis.gost.ru";
        public List<string> UrlPath = new() { "fundmetrology", "eapi" };

        private static readonly HttpClient client = new HttpClient();

        public async Task<List<SiVerificationInfoResult>> GetByType(string orgName, int year = 0, int skip = 0, int take = 10, SortType sort = SortType.Asc)
        {
            var siList = await Get(year: 2022, skip: 1, take: 10, SortType.Asc, search: orgName);
            return siList;
        }

        public async Task<List<SiVerificationInfoResult>> Get(int year = 0, int skip = 0, int take = 10, SortType sort = SortType.Asc, string? search = null)
        {
            if (year == 0)
                year = DateTime.Now.Year;

            var quary = UrlPathBuilder(year, skip, take, sort, search);
            var uri = GetUrl(quary, new() { "vri" });

            var respMess = await client.GetAsync(uri);
            var respMessFromJson = await respMess.Content.ReadFromJsonAsync<Root<SiVerificationInfoResult>>();

            return respMessFromJson?.Result?.Items;
        }

        private string GetUrl(string quary, List<string> paths = null)
        {
            var finalPath = UrlPath;
            if (paths is not null || paths?.Count > 0)
                finalPath.AddRange(paths);

            var url = new UriBuilder()
            {
                Scheme = UrlScheme,
                Host = UrlHost,
                Path = string.Join("/", finalPath),
                Query = quary
            }
            .ToString();
            return url;
        }

        private string UrlPathBuilder(int year, int skip, int take, SortType sort, string search)
        {
            var keyValues = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(search))
                keyValues.Add("search", $"{search}");

            keyValues.Add("year", $"{year}");
            keyValues.Add("start", $"{skip}");
            keyValues.Add("rows", $"{take}");


            var pathsList = keyValues.Select(kv => $"{ kv.Key}={kv.Value}");
            var pathStr = string.Join("&", pathsList);
            return pathStr;
        }
    }

    public enum SortType
    {
        Asc,
        Desc
    }
}

