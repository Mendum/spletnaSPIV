using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spletnaSPIV.Models
{
    public class User : IdentityUser
    {
        public string Password { get; set; }
        public ICollection<Wallet> Wallets { get; set; }
    }
}
