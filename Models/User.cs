using System.ComponentModel.DataAnnotations;

namespace Xapau.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
    }
}