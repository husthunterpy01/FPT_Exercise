using System.ComponentModel.DataAnnotations.Schema;

namespace Mock_2.Model.Entity
{
    public abstract class UserSupervise
    {
        public int? CreatedByID { get; set; }
        public int? LastModifiedByID { get; set; }
        // CreatedBy 1-1 Users
        [ForeignKey("CreatedByID")]
        public virtual User? CreatedBy { get; set; }

        // LastModifiedBy N-1 Users
        [ForeignKey("LastModifiedByID")]
        public virtual User? LastModifiedBy { get; set; }
    }
}
