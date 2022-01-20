

using System.ComponentModel.DataAnnotations;

namespace code_first_db_ci_cd.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [MaxLength(256)]
        public string First { get; set; }

        [MaxLength(256)]
        public string Last { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        public string Company { get; set; }

        //add a comment

    }
}
