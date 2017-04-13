using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalendarPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "";
        string[,] events = new string[5, 2];

        events[0, 0] = "4/24/2017";
        events[0, 1] = "RVL Private Party- 8:00pm";
        events[1, 0] = "4/24/2017";
        events[1, 1] = "Magic Hat in the Grotto- 7:30pm";
        events[2, 0] = "4/24/2017";
        events[2, 1] = "Karaoke with El- 9:30pm";
        events[3, 0] = "4/25/2017";
        events[3, 1] = "Comedy Nest in the Grotto- 7:30pm";
        events[4, 0] = "4/26/2017";
        events[4, 1] = "Fist and Shout- Comedy- 9:00pm";


        string dates = Calendar1.SelectedDate.ToShortDateString();

        for (int i = 0; i < 5; i++)
        {

            if (dates.Equals(events[i, 0]))
            {
                Label1.Text += events[i, 1] + "<br>";
            }

        }
        if (Label1.Text == "") Label1.Text = dates;
    }

}
