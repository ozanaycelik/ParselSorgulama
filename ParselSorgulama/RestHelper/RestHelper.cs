using Newtonsoft.Json;
using ParselSorgulama.Models;
using ParselSorgulama.Models.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParselSorgulama.RestHelper
{
    internal class RestHelper
    {

        private static ServiceResult getTkgmService<T>(string url)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = client.Send(request);
                response.EnsureSuccessStatusCode();
                var deserializeResult = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                return new ServiceResult { status_ = true, exceptionMessage = null, result = deserializeResult };
            }
            catch (Exception ex)
            {
                return new ServiceResult { status_ = true, exceptionMessage = ex.Message, result = null };
            }
        }

        public static ServiceResult GetIlList()
        {
            return getTkgmService<TkgmListDto>("https://parselsorgu.tkgm.gov.tr/app/modules/administrativeQuery/data/ilListe.json");

        }

        public static ServiceResult GetIlceList(int ilValue)
        {
            return getTkgmService<TkgmListDto>($"https://cbsapi.tkgm.gov.tr/megsiswebapi.v3/api//idariYapi/ilceListe/{ilValue}");

        }

        public static ServiceResult GetMahalleList(int ilceValue)
        {
            return getTkgmService<TkgmListDto>($"https://cbsapi.tkgm.gov.tr/megsiswebapi.v3/api/idariYapi/mahalleListe/{ilceValue}");

        }

        public static ServiceResult GetAdaParselInfo(int mahalleValue, int adaNo, int parselNo)
        {
            return getTkgmService<AdaParselDto.AdaParsel>($"https://cbsapi.tkgm.gov.tr/megsiswebapi.v3/api/parsel/{mahalleValue}/{adaNo}/{parselNo}");

        }
    }
}
