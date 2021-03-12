using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spletnaSPIV.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public override string Id { get => base.Id; set => base.Id = value; }
        public string Password { get; set; }
        public ICollection<Wallet> Wallets { get; set; }
    }
}
