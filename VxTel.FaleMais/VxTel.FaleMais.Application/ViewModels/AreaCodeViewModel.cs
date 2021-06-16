using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VxTel.FaleMais.Application.ViewModels
{
    public class AreaCodeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Code is Requied")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "The Description is Requied")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }
    }
}