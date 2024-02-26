using System.ComponentModel.DataAnnotations;

namespace CRM.DTOs.CustomerDTOs
{
    public class SearchQueryCustomerDTO
    {
        [Display(Name = "Nombre")]
        public string? Name_Like { get; set; }
        [Display(Name = "Apellido")]
        public string? LastName_Like { get; set; }
        [Display(Name = "Pagina")]
        public int Skip { get; set; }
        [Display(Name = "Cantreg X Pagina")]
        public int Take { get; set; }
        public byte SendRowCount { get; set; }
    }
}
