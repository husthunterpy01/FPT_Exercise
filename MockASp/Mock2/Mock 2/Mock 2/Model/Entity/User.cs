using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Users")]
    public class User : UserSupervise
    {
        [Key]
        public int UserID { get; set; }
        public int? FacebookUserID { get; set; }
        public int? GoogleUserID { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? DisplayName { get; set; }
        public bool? Active { get; set; }
        public string? ProfileImageLink { get; set; }
        public int? PhoneNumber { get; set; }
        public string? FacebookUrl { get; set; }
        public string? IdentityCardFrontSideImageLink { get; set; }
        public string? IdentityCardBackSideImageLink { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        // Address N-1
        [ForeignKey("AddressID")]
        public Address? Addresses { get; set; }

        // Role N-1
        [ForeignKey("RoleID")]
        public UserRole? UserRoles { get; set; }



    }
    


}
