using HW.Entities.BAL;

namespace HW.Interfaces
{
    public interface IAboutMeService
    {
        Task<MyInfo> GetMyInfo();
        Task<List<MyHobby>> GetMyHobbies();
    }
}
