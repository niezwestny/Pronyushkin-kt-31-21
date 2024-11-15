using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Proekt_Prakt_Lab.Models
{
    public class Discipline
    {
        public int Discipline_ID { get; set; }
        public string Discipline_Name { get; set; }
        public bool IsValidDisciplineName()
        {
            return Regex.Match(Discipline_Name,@"\D*").Success;
        }
        public int Discipline_Load_Hours { get; set; }
        public int? Discipline_Teacher_ID { get; set; }
        [JsonIgnore]
        public Teacher Discipline_Teacher_FIO { get; set; }

    }
}
