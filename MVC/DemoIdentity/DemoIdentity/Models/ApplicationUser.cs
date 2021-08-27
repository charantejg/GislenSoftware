using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DemoIdentity.Models
{
    public class ApplicationUser: IdentityUser
    {
        public Gender Gender { get; set; }
    }

    public enum  Gender { Male , Female}
}
