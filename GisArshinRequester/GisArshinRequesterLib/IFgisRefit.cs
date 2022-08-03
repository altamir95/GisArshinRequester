using System;
using Refit;

namespace GisArshinRequesterLib
{
    public interface IFgisRefit
    {
        //https://fgis.gost.ru/fundmetrology/eapi/vri?year=2022&start=1&rows=10
        [Get("/vri")]
        Task<Root<SiVerificationInfoResult>> GetUser();

        [Get("/vri/{id}")]
        Task<Root<SiVerificationInfoResult>> GetUser(string id);
    }
}

