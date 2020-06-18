using Microsoft.AspNet.Identity;
using phuocthanh_lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace phuocthanh_lab456.Controllers
{
    public class FollowingsController : ApiController
    {
        //private readonly ApplicationDbContext _dbContext;
        //public FollowingsController()
        //{
        //    _dbContext = new ApplicationDbContext();
        //}

        //[HttpPost]
        //public IHttpActionResult Follow(FollowingDto following)
        //{
        //    var userId = User.Identity.GetUserId();
        //    if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId)
        //        return BadRequest("Following already exists!");

        //    var folowing = new Following
        //    {
        //        FollowerId = userId,
        //        FolloweeId = followingDto.FolloweeId
        //    };
        //    _dbContext.Followings.Add(folowing);
        //    _dbContext.SaveChanges();
        //}
        //// GET: Followings
        ////public ActionResult Index()
        ////{
        ////    return View();
        ////}
    }
}