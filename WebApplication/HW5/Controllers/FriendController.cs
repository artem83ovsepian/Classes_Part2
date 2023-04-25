using HW5.Interfaces;
using HW5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HW5.Services;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace HW5.Controllers
{
    public class FriendController : Controller
    {
        private readonly IFriendService _friendService;

        public FriendController()
        {
            _friendService = new FriendService();
        }

        public ActionResult Index()
        {
            var friends = _friendService.GetAll();
            ViewBag.model = friends;
            return View();
        }

        public ActionResult AddNewFriend()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewFriend(Friend friend)
        {
            if (ModelState.IsValid)
            {
                _friendService.Save(friend);
                return RedirectToAction("Index");
            }

            return View(friend);
        }

        public ActionResult DeleteFriend()
        {
            ViewBag.Friends = new SelectList(_friendService.GetAll(), nameof(Friend.FriendID), nameof(Friend.FriendName));
            return View();
        }


        [HttpPost]
        public ActionResult DeleteFriend(int friendId)
        {
            try
            {
                _friendService.Delete(friendId);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FriendEdit()
        {
            ViewBag.Friends = new SelectList(_friendService.GetAll(), nameof(Friend.FriendID), nameof(Friend.FriendName));
            return View();
        }

        public ActionResult FriendGet(int friendId)
        {
            var friend = _friendService.Get(friendId);
            return View("FriendEditPartial", friend);
        }

        [HttpPost]
        public ActionResult FriendEditPartial(Friend friend)
        {
          _friendService.Update(friend);
                return RedirectToAction("Index");
          
        }

    }
}
