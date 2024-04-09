using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Districts")]
    public class District
    {
        [Key]
        public int DistrictID { get; set; }

        public string? DistrictName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<Commune>? Communes { get; set; }
    }
}
