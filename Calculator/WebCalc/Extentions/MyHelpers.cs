using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Extentions
{
    public static class MyHelpers
    {
        public static MvcHtmlString Lister1(this HtmlHelper html, string[] items)
        {
            var ul = new TagBuilder("ul");
            foreach (var item in items)
            {
                var li = new TagBuilder("li"); //Формируем разметку
                li.InnerHtml = item;

                ul.InnerHtml += li;

            }

            return MvcHtmlString.Create(ul.ToString());
        }
    }
}