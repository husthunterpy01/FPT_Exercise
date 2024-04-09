using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        public string? Adddresses { get; set; }
        public string? GoogleMapLocation { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifieddate { get; set; }

        public ICollection<Campus>? Campuses { get; set; }
        public House? Houses { get; set; }
        public ICollection<User>? Users { get; set; }

    }
}
