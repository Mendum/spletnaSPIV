using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spletnaSPIV.Models
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public Currency Currency { get; set; }


        public ApplicationUser User { get; set; }
    }
}
