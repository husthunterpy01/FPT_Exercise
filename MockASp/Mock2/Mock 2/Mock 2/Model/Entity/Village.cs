using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Villages")]
    public class Village
    {
        [Key]
        public int VillageId { get; set; }
        public string? VillageName { get; set; }
        public DateTime? CreatedDate { get; set; }
        [ForeignKey("CommuneID")]
        public Commune? Communes { get; set; }
        public ICollection<House> Houses { get; set; }
    }
}
