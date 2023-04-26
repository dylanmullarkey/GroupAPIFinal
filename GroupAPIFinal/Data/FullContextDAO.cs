using GroupAPIFinal.Interfaces;
using GroupAPIFinal.Models;

namespace GroupAPIFinal.Data
{
    public class FullContextDAO : IFullContextDAO
    {
        FullContext _context;
        public FullContextDAO(FullContext context)
        {
            _context = context;
        }
        public List<UserInfo> GetUserInfos()
        {
            return _context.UserInfo.ToList();
        }
        public List<UserFoods> GetUserFoods()
        {
            return _context.Foods.ToList();
        }
        public List<UserHobbies> GetHobbiess()
        {
            return _context.Hobbies.ToList();
        }
        public List<UserLocationInfo> GetUserLocationInfos()
        {
            return _context.UserLocation.ToList();
        }
        public List<UserMusic> GetUserMusics()
        {
            return _context.Music.ToList();
        }
    }
}