using ParselSorgulama.Models;

namespace ParselSorgulama.Helper
{
    public static class ParselHelper
    {
        public static ServiceResult GetIlList()
        {
            return RestHelper.RestHelper.GetIlList();
        }

        public static ServiceResult GetIlceList(int ilValue)
        {
            return RestHelper.RestHelper.GetIlceList(ilValue);
        }

        public static ServiceResult GetMahalleList(int ilcelValue)
        {
            return RestHelper.RestHelper.GetMahalleList(ilcelValue);
        }
        public static ServiceResult GetAdaParselInfo(int mahalleValue, int adaNo, int parselNo)
        {
            return RestHelper.RestHelper.GetAdaParselInfo(mahalleValue, adaNo, parselNo);
        }
    }
}