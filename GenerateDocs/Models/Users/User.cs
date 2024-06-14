using GenerateDocs.Models.EducationProgramms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateDocs.Models.Users
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string  Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<EducationProgramm> EducationProgramms { get; set; }
    }
}
