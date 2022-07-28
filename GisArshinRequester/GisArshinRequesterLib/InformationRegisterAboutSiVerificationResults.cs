namespace GisArshinRequesterLib
{
    public class InformationRegisterAboutSiVerificationResults
    {
        // https://fgis.gost.ru/fundmetrology/eapi/vri?year=2020&start=5&rows=20
        public string UrlScheme = "https://";
        public string UrlHost = "fgis.gost.ru";
        public List<string> UrlPath = new() { "fundmetrology", "eapi" };

        private static readonly HttpClient client = new HttpClient();

        public async Task<HttpResponseMessage> Get(int year,int skip,int take,SortType sort)
        {

            var r = new Dictionary<string, string>
            {
                { "year", $"{year}" },
                { "start", $"{skip}" },
                { "rows", $"{take}" }
                //{ "sort", sort.ToString().ToLower() }
            };

            var quary = UrlPathBuilder(r);
            var uri = GetUrl(quary, new() { "vri" });

            var result = await client.GetAsync(uri);


            return result;
        }

        private string GetUrl(string quary,List<string> paths=null)
        {
            var finalPath = UrlPath;
            if (paths is not null || paths?.Count > 0)
                finalPath.AddRange(paths);

            var url = new UriBuilder() {
                Scheme = UrlScheme,
                Host = UrlHost,
                Path = string.Join("/", finalPath),
                Query = quary
            }
            .ToString();
            return url;
        }

        private string UrlPathBuilder(Dictionary<string,string> keyValues)
        {
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

