using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AuthorList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PersonKey"] != null)
        {
            Community_AssistEntities db = new Community_AssistEntities();
            int key = (int)Session["PersonKey"];
            var don = (from d in db.Donations
                       where d.PersonKey == key
                       select d).ToList();
            GridView1.DataSource = don;
            GridView1.DataBind();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}
