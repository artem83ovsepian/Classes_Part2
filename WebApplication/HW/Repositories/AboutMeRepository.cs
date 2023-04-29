using HW.Entities.DAL;

namespace HW.Repositories
{
    public class AboutMeRepository
    {
        private MyDescription _myDescription = new MyDescription()
        {
            Name = "Gandalf",
            Description = "the last of the wizards in Middle-earth",
            DateBirth = DateTime.Parse("08/18/1235"),
            Education = "Self-Educated",
            Photo = "/images/MyPicture.jpg",
            URL = "https://en.wikipedia.org/wiki/Gandalf",
            PersonalQualities = new List<string> { "Wise", "Stubborn", "Never give up hope" },
            Hobbies = new List<Hobby>
                {
                    new Hobby {Id = 1, Name = "Knitting", Photo = "/images/hobbies/Knitting.jpg", Description = "Instead of picking up your phone whenever you're free, the knitting hobby is a healthier way to kill time. All you need is any old ball of wool, some knitting needles and either someone to give you an hour of their time to show you the basics or a fish about on Youtube for a good video. "},
                    new Hobby {Id = 2, Name = "Dance", Photo = "/images/hobbies/dance.jpg", Description = "I have tried a lot of dance styles: folk dance, elegant ballroom dance, ballet dance and even lively hip-hop and break-dance. I was really fond of slow waltz, tango, rumba, salsa and cha-cha-cha."},
                    new Hobby {Id = 3, Name = "Parachuting", Photo = "/images/hobbies/Parachuting.jpg", Description = "Parachuting, including also skydiving, is a method of transiting from a high point in the atmosphere to the surface of Earth with the aid of gravity, involving the control of speed during the descent using a parachute or parachutes."}
                }
        };

        public MyDescription Get()
        {
            return _myDescription;
        }

        public List<Hobby> GetHobbies()
        {
            return _myDescription.Hobbies;
        }
    }
}
