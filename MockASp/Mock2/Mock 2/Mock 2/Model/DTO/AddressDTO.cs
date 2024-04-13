using Mock_2.Model.Entity;

namespace Mock_2.Model.DTO
{
    public class AddressDTO
    {
        public int AddressID { get; set; }

        public string? Addresses { get; set; }
        public string? GoogleMapLocation { get; set; }
        public int? HouseID { get; set; }
        public House? Houses { get; set; }
        public ICollection<Campus>? Campuses { get; set; }  
        public ICollection<User>? Users { get; set; }
    }
}
