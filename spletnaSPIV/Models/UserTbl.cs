using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace spletnaSPIV.Models
{
    public class UserTbl
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Display(Name = "First Name")]
        public string FristName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public WalletTbl FK_Wallet_Id { get; set; }
    }
}
