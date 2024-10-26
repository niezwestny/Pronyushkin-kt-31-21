namespace Proekt_Prakt_Lab.Models
{
    public class Teacher
    {
        public int Teacher_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Second_Name { get; set; }
        public int Cafedra_ID { get; set; }
        public Cafedra Cafedra { get; set; }
        public int Position_ID { get; set; }
        public Position Position { get; set; }
        public int Degree_ID { get; set; }
        public Degree Degree { get; set; }
        public int Load_ID { get; set; }
        public Load Load { get; set; }
        public int Discipline_ID { get; set; }
        public Discipline Discipline { get; set; }

    }
}
