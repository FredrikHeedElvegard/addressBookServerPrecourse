using System;

namespace addressBookServerPrecourse.Models;

public class Db
{
    public List<Address> Addresses { get; set; }

    public Db()
    {
        Addresses = new()
        {
            new(){ Street= "Stagneliusvägen" , LastName ="Elvegard" , StreetNr=39 },
            new(){ Street= "Vitalisvägen" , LastName ="Lothrok" , StreetNr=3}
        };
    }
}
