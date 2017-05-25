using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IBookReviewService
{
    [OperationContract]
    int Login(string email, string password);

    [OperationContract]
    bool RegisterPerson(PersonInfo r);

    [OperationContract]
    List<Grants> GetGrantRequest(int PersonKey);

    [OperationContract]
    bool newGrant(GrantRequest grequest, GrantReview greview);

}

public class PersonInfo
{
    [DataMember]
    public string PersonLastName { get; set; }

    [DataMember]
    public string PersonFirstName { get; set; }

    [DataMember]
    public string PersonEmail { get; set; }

    [DataMember]
    public string PersonPassWord { get; set; }

    [DataMember]
    public string PersonEntryDate { get; set; }

    [DataMember]
    public string PersonPassWordSeed { get; set; }
}

[DataContract]

public partial class Grants {
   
    [DataMember]
    public string GrantRequestDate { get; set; }

    [DataMember]
    public string PersonKey { get; set; }

    [DataMember]
    public string GrantTypeKey { get; set; }

    [DataMember]
    public string GrantRequestExplanation { get; set; }

    [DataMember]
    public string GrantRequestAmount { get; set; }
    public IEnumerable<Grants> Grants1 { get; internal set; }
}
