namespace Proekt_Prakt_Lab.Models
{
    public class Cafedra
    {
        public int Cafedra_ID { get; set; }
        public string Cafedra_Name { get; set; }
        public int Main_Teacher_ID { get; set; }
        public Teacher Main_teacher { get; set; }
    }
}
