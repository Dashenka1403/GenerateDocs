using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GenerateDocs.Models.EducationProgramms;

namespace GenerateDocs.Models.Disciplines
{
    public class Discipline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CodeDiscipline { get; set; }
        public string ShortName { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Goal { get; set; }
        public string Task { get; set; }
        //public EducationProgramm EducationProgramm { get; set; }
        public List<DisciplineInfo> DisciplineInfos { get; set; }
        public List<LaborIntensity> LaborIntensities { get; set; }
    } 
}
