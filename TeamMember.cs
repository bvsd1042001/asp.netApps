using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResponsiveTeamMemberWebPage.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
    }
}