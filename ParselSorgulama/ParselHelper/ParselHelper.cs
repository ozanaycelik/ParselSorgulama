using ParselSorgulama.Models;

namespace ParselSorgulama.Helper
{
    public class ParselHelper
    {
        public ServiceResult GetIlList()
        {
            return RestHelper.RestHelper.GetIlList();
        }

        public ServiceResult GetIlceList(int ilValue)
        {
            return RestHelper.RestHelper.GetIlceList(ilValue);
        }

        public ServiceResult GetMahalleList(int ilcelValue)
        {
            return RestHelper.RestHelper.GetMahalleList(ilcelValue);
        }
        public ServiceResult GetAdaParselInfo(int mahalleValue, int adaNo, int parselNo)
        {
            return RestHelper.RestHelper.GetAdaParselInfo(mahalleValue, adaNo, parselNo);
        }
    }
}