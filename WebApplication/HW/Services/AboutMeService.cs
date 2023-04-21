using HW.Entities.BAL;
using HW.Interfaces;
using HW.Repositories;

namespace HW.Services
{
    public class AboutMeService : IAboutMeService
    {
        private AboutMeRepository _repository;
        private MyUtilities _myUtilities;

        public AboutMeService() 
        {
            _repository = new AboutMeRepository();
            _myUtilities = new MyUtilities();
        }
        public async Task<MyInfo> GetMyInfo()
        {
            var myDescription = _repository.Get();
            return new MyInfo()
            {
                Name = myDescription.Name,
                Age = _myUtilities.GetAge(myDescription.DateBirth),
                Description = myDescription.Description,
                Education = myDescription.Education,
                URL = myDescription.URL,
                PersonalQualities = myDescription.PersonalQualities,
                Photo = myDescription.Photo
            };
        }
        public async Task<List<MyHobby>> GetMyHobbies()
        {
            var hobbies = _repository.GetHobbies();
            return hobbies.Select(x => new MyHobby { Id = x.Id, Name = x.Name, Description = x.Description, Photo = x.Photo }).ToList();
        }
    }
}
