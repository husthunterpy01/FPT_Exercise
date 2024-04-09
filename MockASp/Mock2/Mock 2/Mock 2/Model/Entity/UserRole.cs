using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("UserRoles")]
    public class UserRole
    {
        [Key]
        public int? RoleID { get; set; }
        public string? RoleName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<User>? Users { get; set; }

    }
}
