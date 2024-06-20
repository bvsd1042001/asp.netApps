using ResponsiveTeamMemberWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResponsiveTeamMemberWebPage.Controllers
{
    public class TeamMemberController : Controller
    {
        private List<TeamMember> _teamMembers = new List<TeamMember>
    {
        new TeamMember { Id = 1, Name = "John Doe", Position = "CEO", ImageUrl = "/images/john-doe.jpg" },
        new TeamMember { Id = 2, Name = "Jane Doe", Position = "CTO", ImageUrl = "/images/jane-doe.jpg" },
        // Add more team members as needed
    };
        public ActionResult Index()
        {
            return View(_teamMembers);
        }

    }
}