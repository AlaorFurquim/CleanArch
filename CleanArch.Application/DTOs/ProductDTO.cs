using CleanArch.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is Required")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string Description { get; private set; }


        [Required(ErrorMessage = "The Price is Required")]
        [Column(TypeName ="Decimal(18,2)")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        [DisplayName("Price")]

        public decimal Price { get; private set; }

        [Required(ErrorMessage = "The Stock is Required")]
        [Range(1,9999)]
        [DisplayName("Stock")]
        public int Stock { get; private set; }
        [MinLength(250)]
        [DisplayName("Image")]
        public string Image { get; private set; }

        public int CategoryId { get; set; }

        [DisplayName("Categories")]
        public Category Category { get; set; }
    }
}
