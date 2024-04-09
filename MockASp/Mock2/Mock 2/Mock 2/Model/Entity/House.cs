using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    [Table("Houses")]
    public class House : UserSupervise
    {
        [Key]
        public int HouseID { get; set; }

        public string? HouseName { get; set; }
        public string? Information { get; set; }
        public int? PowerPrice { get; set; }
        public int? WaterPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        // Villages N - 1
        [ForeignKey("VillageID")]
        public Village? Villages { get; set; }
        // Campuses N -1 
        [ForeignKey("CampusID")]
        public Campus? Campuses { get; set; }
        // HouseImages (1-N)
        public ICollection<HouseImage>? HouseImages { get; set; }
        // Reports (1 - N )
        public ICollection<Report>? Reports { get; set; } 
        // Rooms (FK: Rooms 1 - N)
        public ICollection<Room>? Rooms { get; set; }
        // Rates (FK: 1 - N )
        public ICollection<Rate>? Rate { get; set; }
        // LandLord(FK: LandLordID N- 1)
        [ForeignKey("LandlordID")]
        public User? Landlord { get; set; }
        // Addresses (FK - AddressID 1 -1 )
        [ForeignKey("AddressID")]
        public Address? Addresses { get; set; }


    }
}
