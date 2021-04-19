using System.ComponentModel.DataAnnotations;
namespace BPMWebApi.Library.Models {
    public class User {
        [Key]
        public int Id { get; set; }
        
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
