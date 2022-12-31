using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FarmingCattleApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the FarmingCattleAppUser class
public class FarmingCattleAppUser : IdentityUser
{
    public string? Email { get; set; }
    


}

