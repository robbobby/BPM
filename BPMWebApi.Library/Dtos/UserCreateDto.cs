using System.ComponentModel.DataAnnotations;
namespace BPMWebApi.Library.Dtos {
    public class UserCreateDto {
        
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }
    }
}
