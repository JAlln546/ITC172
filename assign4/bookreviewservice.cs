using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class BookReviewService : IBookReviewService
{
    Community_Assist db = new Community_Assist();
    public Grants GetGrant(string grantRequest)
    {
        throw new NotImplementedException();
    }

    public List<Grants> GetGrants()
    {
        //this method returns all grants
        var Grants = from b in db.GrantRequest
                  select b;
                
        List<Grants> grants = new List<Grants>();
        foreach(Grants gr in Grants)
        {
            Grants grant1 = new Grants();
            grant1.GrantRequestDate = gr.GrantRequestDate.ToShortDateString();
            grant1.PersonKey = gr.PersonKey;
            grant1.GrantTypeKey = gr.GrantTypeKey;
            grant1.GrantRequestExplanation = gr.GrantRequestExplanation;
            grant1.GrantRequestAmount = gr.GrantRequestAmount;

            foreach (Grants a in gr.Grants)
            {
                grant1.GrantTypeKey.Add(gr);  //Grant Tyle
            }
            //add to the list of grants
            grants.Add(grant1);
        }
        return grants;
    }

    public List<Grants> GetGrants(string GrantRequest)
    {
        throw new NotImplementedException();
    }

    public List<Grants> GetGrantsByGrantRequest(string grantRequest)
    {
        var grs = from b in db.Grants
                  from a in b.GrantRequest
                  where a.GrantRequestTyle.Equals(grantRequest)
                  select b;
        List<Grants> grants = new List<Grants>();
        foreach(var gr in grs)
        {
            Grants grant = new Grants();
            grants.GrantRequestDate = gr.GrantRequestDate.ToShortDateString();
            grants.PersonKey = gr.PersonKey;
            grants.GrantTypeKey = gr.GrantTypeKey;
            grants.Add(grant);

        }
        return grants;
    }

    public int Login(string user, string password)
    {
        int key = 0;
        int result = db.usp_ReviewerLogin(user, password);
        if (result != -1)
        {
            var userKey = (from k in db.Reviewers
                           where k.ReviewerUserName.Equals(user)
                           select k.ReviewerKey).FirstOrDefault();
            key = (int)userKey;
        }
        return key;
    }

    public bool RegisterPerson(Person r)
    {
        throw new NotImplementedException();
    }

    public bool RegisterReviewer(Reviewer r)
    {
        bool result = true;
        int rev = db.usp_NewReviewer(r.ReviewerUserName,
            r.ReviewerFirstName, r.ReviewerLastName,
            r.ReviewerEmail, r.ReviewPlainPassword);
    }
}
