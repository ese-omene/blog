using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blog
{
    public partial class newblogpost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddPost(object sender, EventArgs e)
        {
            BLOGDB db = new BLOGDB();

            BLOGPOST new_post = new BLOGPOST();

            new_post.SetPTitle(page_title.Text);
            new_post.SetPBody(page_body.Text);

            db.Add_Post(new_post);

            Response.Redirect("blogarchive.aspx");
        }
    }
}