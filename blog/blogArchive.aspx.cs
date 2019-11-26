using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace blog
{
    public partial class blogArchive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            bloglist_result.InnerHtml = "";


            string query = "select * from blog_page";
            var db = new BLOGDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                bloglist_result.InnerHtml += "<div class=\"listitem\">";

                 string pageid = row["pageid"];

                string pagetitle = row["pagetitle"];
                bloglist_result.InnerHtml += "<div class\"col2\">" + pagetitle + "</div>";

                string pagebody = row["pagebody"];
                bloglist_result.InnerHtml += "<div class=\"col2last\">" + pagebody + "</div>";

                bloglist_result.InnerHtml += "</div>";
            }


        }
    }
}