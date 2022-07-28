// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using GisArshinRequesterLib;

var si = new InformationRegisterAboutSiVerificationResults();
var res =await si.Get(year: 2022, skip: 1, take: 10, SortType.Asc);
var obj = await res.Content.ReadFromJsonAsync<Root<SiVerificationInfoResult>>();

Console.ReadLine();

