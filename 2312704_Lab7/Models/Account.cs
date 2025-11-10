using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Entity_Framework.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [StringLength(100)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [Required]
        [StringLength(1000)]
        public string FullName { get; set; }

        [StringLength(1000)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Tell { get; set; }

        public DateTime? DateCreated { get; set; }

        // Navigation properties
        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
    }
}
