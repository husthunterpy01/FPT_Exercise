using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Communes")]
    public class Commune
    {
        [Key]
        public int CommunesId { get; set; }
        public string? CommuneName { get; set; }
        public DateTime? DateTime { get; set; }
        [ForeignKey("DistrictID")]
        public District? Districts { get; set; }
        public ICollection<Village>? Villages { get; set; }
    }
}
