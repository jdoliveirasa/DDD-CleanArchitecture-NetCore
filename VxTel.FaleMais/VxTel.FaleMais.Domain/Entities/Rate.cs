using System.ComponentModel.DataAnnotations;

namespace VxTel.FaleMais.Domain.Entities
{
    public class Rate
    {
        [Key]

        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
