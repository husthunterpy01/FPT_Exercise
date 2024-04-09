using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("RoomHistory")]
    public class RoomHistory : UserSupervise
    {
        [Key]
        public int RoomHistoryID { get; set; }
        public string? CustomerName { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        // N-1 RoomID
        [ForeignKey("RoomID")]
        public Room? Rooms { get; set; }

    }
}
