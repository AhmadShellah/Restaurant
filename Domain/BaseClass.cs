using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public abstract class BaseClass
    {
        [Key]
        public int Id { get; set; }

        public int CreatedBy { get; set; }

        public int? DeletedBy { get; set; }

        public int? UpdateBy { get; set; }

        public bool Deleted { get; set; } = false;

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
