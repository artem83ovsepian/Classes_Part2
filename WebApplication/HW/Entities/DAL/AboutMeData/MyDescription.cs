namespace HW.Entities.DAL
{
    public class MyDescription
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Education { get; set; }
        public List<Hobby>? Hobbies { get; set;}
        public List<string>? PersonalQualities { get; set; }
        public string URL { get; set; }
        public string Photo { get; set; }
    }
}
