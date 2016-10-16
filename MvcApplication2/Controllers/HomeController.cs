using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        #region 初始化数据集合 +List InitData()
        /// <summary>
        /// 初始化数据集合
        /// </summary>
        /// <returns></returns>
        public List<Models.Child> InitData()
        {
            List<Models.Child> list = new List<Models.Child>()
            {
                new Models.Child(){Id=1,StrName="你好啊！"},
                new Models.Child() {Id=2,StrName="不好啊！"}
            };
            return list;
        }

        #endregion

        /// <summary>
        /// Action方法（相当于MVC设计模式的Model）
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            StringBuilder strBuilder = new StringBuilder();
            List<Models.Child> list = InitData();
            list.ForEach(d =>
                {
                    strBuilder.AppendLine("<div>" + d.Id.ToString() + ":" + d.StrName.ToString() + "</div>");
                });

            ViewBag.HtmlStrBuilder = strBuilder.ToString();

            return View();

        }
    }
}
