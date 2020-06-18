using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using phuocthanh_lab456.Models;

namespace phuocthanh_lab456.Controllers
{
    public class FollowingDto
    {
        public string FolloweeId { get; set; }
    }
}