using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Identity
{
  public class AppUser: IdentityUser 
        //then this drive from identity user,
        //which uses the string as the id as primary key
        //identity is the separate context boundary to the rest of our application

    {
        public string DisplayName { get; set; }

        public Address Address { get; set; }
    }
}
