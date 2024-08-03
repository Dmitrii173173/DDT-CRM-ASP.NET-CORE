using System.ComponentModel.DataAnnotations;

namespace DDT_CRM.Models
{
    public class Users
    {
        [Key]
        public int userId { get; set; }

        [Required]
        public String name { get; set; } = "";

        [Required]
        public String address { get; set; } = "";
    }
}
