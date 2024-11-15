using Proekt_Prakt_Lab.Models;
namespace Proekt_Prakt_Lab.Tests
{
	public class DisciplineTest
	{
		[Fact]
		public void IsValidDisciplineName_Math()
		{
			var testDiscipline = new Discipline
			{
				Discipline_Name = "Math"
			};
			var result = testDiscipline.IsValidDisciplineName();
			Assert.True(result);
		}
		
	
	}
}