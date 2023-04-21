using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HW.Entities.BAL;
using HW.Services;

namespace HW.Pages
{
    
    public class MyHobbiesModel : PageModel
    {
        private AboutMeService _aboutMeService;

        public string PageName { set; get; } = "My Hobbies";

        [BindProperty]
        public List<MyHobby> MyHobbies { get; set; }        

        public MyHobbiesModel()
        {
            _aboutMeService = new AboutMeService();
        }
        public async Task<IActionResult> OnGetAsync()
        {
            var myHobbies = await _aboutMeService.GetMyHobbies();
            MyHobbies = myHobbies.ToList();
            return Page();
        }
    }
}
