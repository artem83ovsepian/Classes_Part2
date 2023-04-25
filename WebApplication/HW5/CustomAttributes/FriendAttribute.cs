using HW5.Reposiitories;
using System.ComponentModel.DataAnnotations;

namespace HW5.CustomAttributes
{
    public class FriendAttribute : ValidationAttribute
    {
        private FriendRepository _repo = new FriendRepository();

        public override bool IsValid(object? value)
        {
            return _repo.IsUniqueId((int)value);
        }        
    }
}
