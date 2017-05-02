using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AuthorPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["PersonKey"]==null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        Donation a = new Donation();
        a.DonationAmount = Decimal.Parse(DonationAmountTextBox.Text);
        a.DonationDate = DateTime.Now;
        a.PersonKey = (int)Session["PersonKey"];

        db.Donations.Add(a);
        db.SaveChanges();

        Response.Redirect("AuthorList.aspx");
        
        
    }
}
