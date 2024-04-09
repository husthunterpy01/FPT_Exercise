using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("HouseImages")]
    public class HouseImage : UserSupervise
    {
        [Key]
        public int ImageID { get; set; }
        public string? ImageLink { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        // FK HouseID N-1
        public House? Houses { get; set; }
  
    }

}
