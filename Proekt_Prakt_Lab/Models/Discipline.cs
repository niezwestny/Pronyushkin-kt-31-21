namespace Proekt_Prakt_Lab.Models
{
    public class Discipline
    {
        public int Discipline_ID { get; set; }
        public string Discipline_Name { get; set; }
        public int? Discipline_Load_Id { get; set; }
        public Load Discipline_Load_Hours { get; set; }
    
    }
}
