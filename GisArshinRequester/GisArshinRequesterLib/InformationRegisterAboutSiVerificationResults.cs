// https://fgis.gost.ru/fundmetrology/eapi/vri?year=2020&start=5&rows=20
using System.Net.Http.Json;
using Refit;

namespace GisArshinRequesterLib
{
    public class InformationRegisterAboutSiVerificationResults
    {
        public async Task<List<SiVerificationInfoResult>> GetListAsync()
        {
            var refit = RestService.For<IFgisRefit>("https://fgis.gost.ru/fundmetrology/eapi");
            var res = await refit.GetUser();

            return res.Result.Items;
        }

        public async Task<List<SiVerificationInfoResult>> GetByIdAsync()
        {
            var refit = RestService.For<IFgisRefit>("https://fgis.gost.ru/fundmetrology/eapi");
            var res = await refit.GetUser();

            return res.Result.Items;
        }
    }
}

