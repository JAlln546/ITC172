using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.

public class BookReviewService : IBookReviewService
{
    Community_AssistEntities db = new Community_AssistEntities();
  


    public List<Grants> GetGrantRequest(int Person)
    {
        //this method returns all grants
        var Grants = from b in db.GrantRequests
                  select b;
                
        List<Grants> grants = new List<Grants>();
        foreach (Grants gr in grants)
        {
            Grants grant1 = new Grants();
            grant1.GrantRequestDate = gr.GrantRequestDate;
            grant1.PersonKey = gr.PersonKey;
            grant1.GrantTypeKey = gr.GrantTypeKey;
            grant1.GrantRequestExplanation = gr.GrantRequestExplanation;
            grant1.GrantRequestAmount = gr.GrantRequestAmount;

           
            //add to the list of grants
            grants.Add(grant1);
        }
        return grants;
    }
    


    public bool RegisterPerson(PersonInfo r)
    {
        bool result = true;
        int rev = db.usp_Register(r.PersonLastName, r.PersonFirstName, r.PersonEmail, r.PersonPassWord, r.PersonApartmentNumber,
            r.PersonStreet, r.PersonCity, r.PersonState, r.PersonZipcode, r.PersonHomePhone, r.PersonWorkPhone);

        return result;
    }


    public bool newGrant(GrantRequest grequest, GrantReview greview)
    {
        bool result = true;

        try
        {
            db.GrantRequests.Add(grequest);
            db.GrantReviews.Add(greview);
            db.SaveChanges();
        }

        catch
        {
            result = false;
        }

        return result;
    }
    


    public int Login(string email, string password)
    {
        int key = 0;
        int result = db.usp_Login(email, password);
        if (result != -1)
        {
            var personKey = (from k in db.People
                           where k.PersonEmail.Equals(email)
                           select k.PersonKey).FirstOrDefault();
            key = (int)personKey;
        }
        return key;
    }


}
