using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint_0_Group_4.Models
{
    [Table("app_user")]
    public class AppUser
    {
        [Column("app_user_id")]
        public int AppUserId { get; set; }

        [Column("username")]
        public string Username { get; set; } = null!;

        [Column("password")]
        public string Password { get; set; } = null!;

        [Column("firstname")]
        public string? Firstname { get; set; }

        [Column("lastname")]
        public string? Lastname { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("avatar")]
        public string? Avatar { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
