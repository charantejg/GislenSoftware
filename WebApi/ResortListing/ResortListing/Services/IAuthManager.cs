using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResortListing.Data;

namespace ResortListing.Services
{
   public interface IAuthManager
   {
       Task<string> CreateToken(ApplicationUser user);


   }
}
