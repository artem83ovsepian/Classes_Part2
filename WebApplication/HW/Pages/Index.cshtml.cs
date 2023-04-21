using HW.Entities.BAL;
using HW.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HW.Pages
{
    public class AboutMeModel : PageModel
    {
        public string PageName { set; get; } = "About Me";

        private AboutMeService _aboutMeService;

        public AboutMeModel()
        {
            _aboutMeService = new AboutMeService();
        }

        [BindProperty]
        public List<string> PersonalQualities { get; set; }

        [BindProperty, Required]
        public string Name { get; set; }

        [BindProperty]
        public string Photo { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public string Education { get; set; }

        [BindProperty, Url]
        public string URL { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var aboutMe = await _aboutMeService.GetMyInfo();

            PersonalQualities = aboutMe.PersonalQualities;
            Name = aboutMe.Name;
            Photo = aboutMe.Photo;
            Description = aboutMe.Description;
            Age = aboutMe.Age;
            Education = aboutMe.Education;
            URL = aboutMe.URL;
            return Page();
        }

        //public async void OnGetAsync()
        //{

        //    ViewData["URL"] = aboutMe.URL; 
        //}
    }
}
