using GroupAPIFinal.Models;

namespace GroupAPIFinal.Interfaces
{
    public interface IFullContextDAO
    {
        List<UserFoods> GetUserFoods();
        List<UserInfo> GetUserInfos();
        List<UserHobbies> GetHobbiess();
        List<UserLocationInfo> GetUserLocationInfos();
        List<UserMusic> GetUserMusics();
    }
}