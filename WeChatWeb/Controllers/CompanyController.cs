using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeChatWeb.Models;

namespace WeChatWeb.Controllers
{
    public class CompanyController : Controller
    {
        private IList<CompaniesListModel> companies = new List<CompaniesListModel>();

        public CompanyController()
        {
            companies.Add(new CompaniesListModel() { Id = 1, Name = "Lenovo", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 2, Name = "腾讯", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 3, Name = "中科院", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 4, Name = "百度", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 5, Name = "大街", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 6, Name = "思科网络信息科技", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 7, Name = "千人计划", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 8, Name = "巨人网络", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 9, Name = "招商银行", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 10, Name = "交通银行", FollowedUsersCount = 100 });
            companies.Add(new CompaniesListModel() { Id = 11, Name = "浦发银行", FollowedUsersCount = 100 });
        }

        public ActionResult List(int page = 0)
        {
            if (page > Convert.ToInt32(Math.Floor(companies.Count / 5.0))) page = Convert.ToInt32(Math.Floor(companies.Count / 5.0));
            ViewBag.CurrentPage = page;
            return View(companies.Skip(page * 5).Take(5).ToList());
        }

    }
}
