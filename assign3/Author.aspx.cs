using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Author : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        BookReviewDbEntities db = new BookReviewDbEntities();
        Author a = new Author();
        a.AuthorName = DonationAmountTextBox.Text;

        db.Authors.Add(a);
        db.SaveChanges();
    }
}