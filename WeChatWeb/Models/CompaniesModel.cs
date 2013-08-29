using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeChatWeb.Models
{
    public class CompaniesListModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int FollowedUsersCount { get; set; }
    }
}