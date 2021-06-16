using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VxTel.FaleMais.Application.ViewModels
{
    public class PlanViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Description is Requied")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Minutes is Requied")]
        [Range(1, 99999)]
        [DisplayName("Minutes")]
        public int Minutes { get; set; }
    }
}