using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string firstname = FirstNameTextBox.Text;
        string lastname = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string streetName = StreetName.Text;
        string apartmentNumber = ApartmentNumber.Text;
        string city = City.Text;
        string state = State.Text;
        string zipCode = ZipCode.Text;
        string HomePhone = PhoneNumber.Text;
        string WorkPhone = WorkNumber.Text;
        // string user = UserTextBox.Text;
        string password = ConfirmTextBox.Text;

        Community_AssistEntities db = new Community_AssistEntities();
        int result = db.usp_Register(lastname, firstname, email, password, apartmentNumber, streetName, city, state, zipCode, 
            HomePhone, WorkPhone);
        if (result != -1)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something went terribly wrong";
        }

    }
}
