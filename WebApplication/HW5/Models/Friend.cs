using HW5.CustomAttributes;
using System.ComponentModel.DataAnnotations;

namespace HW5.Models
{
    public class Friend
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0.")]
        [Friend(ErrorMessage = "This Friend Id already exists.")]
        public int FriendID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Empty Friend Name not allowed.")]
        public string FriendName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Place must be between 3 and 25 character in length.")]
        public string Place { get; set; }
    }
}
