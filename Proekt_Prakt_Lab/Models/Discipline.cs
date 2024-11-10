namespace Proekt_Prakt_Lab.Models
{
    public class Discipline
    {
        public int Discipline_ID { get; set; }
        public string Discipline_Name { get; set; }
        public int Discipline_Load_Hours { get; set; }
        public int? Discipline_Teacher_ID { get; set; }
        public Teacher Discipline_Teacher_FIO { get; set; }

    }
}
