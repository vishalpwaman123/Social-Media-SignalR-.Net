using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Model.Context
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [EmailAddress, NotNull]
        public string Email { get; set; }

        [NotNull]
        public string Password { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
