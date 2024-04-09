using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Campuses")]
    public class Campus
    {
        [Key]
        public int CampusID { get; set; }
        public string? CampusName { get; set; }
        public DateTime? CreatedDate { get; set; }
        [ForeignKey("AddressID")]
        public Address? Addresses { get; set; }
        public ICollection<House>? Houses { get; set; }
    }
}
