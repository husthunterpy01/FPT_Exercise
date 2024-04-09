using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Rates")]
    public class Rate : UserSupervise
    {
        [Key]
        public int RateID { get; set; }

        public int? Star { get; set; }
        public string? Comment { get; set; }
        public string? LandLordReply { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        [ForeignKey("HouseID")]
        public House? House { get; set; }
        [ForeignKey("StudentID")]
        public User? Student { get; set; }
    }
}
