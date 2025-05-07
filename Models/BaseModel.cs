using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using phuclien_company.Interfaces;

namespace phuclien_company.Models
{
    public abstract class BaseModel : IBaseModel
    {
        [Key]
        public Guid Id { get; set; }

        [NotMapped]
        public Guid GetKey { get => Id; }
    }
}