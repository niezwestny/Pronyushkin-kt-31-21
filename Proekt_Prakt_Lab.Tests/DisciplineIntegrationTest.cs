using Microsoft.EntityFrameworkCore;
using Proekt_Prakt_Lab.Database;
using Proekt_Prakt_Lab.Filters;
using Proekt_Prakt_Lab.Interfaces.DisciplineInterfaces;
using Proekt_Prakt_Lab.Interfaces.LoadInterfaces;
using Proekt_Prakt_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_Prakt_Lab.Tests
{
	public class DisciplineIntegrationTest
	{
		public readonly DbContextOptions<TeacherDbContext> _dbContextOptions;
		public DisciplineIntegrationTest()
		{
			this._dbContextOptions = new DbContextOptionsBuilder<TeacherDbContext>()
				.UseInMemoryDatabase("temp_test_db")
				.Options;
		}
		[Fact]
		public async Task GetDisciplineByTeacher_1_TwoObjects()
		{   
			var context = new TeacherDbContext(_dbContextOptions);
			var disciplineService = new DisciplineService(context);
			var Discipline = new List<Discipline>
			{
				new Discipline
				{
					Discipline_Name = "Math",
					Discipline_Teacher_ID = 1,
					Discipline_Load_Hours = 1,
				},
				new Discipline
				{
					Discipline_Name = "NotMath",
					Discipline_Teacher_ID =2,
					Discipline_Load_Hours=25
				}
			};
			await context.Set<Discipline>().AddRangeAsync(Discipline);
			await context.SaveChangesAsync();

			var teacher_test = new List<Teacher>
			{ new Teacher{
			   Surname="Petrov",
			   Second_Name="Vasilievich",
			   Name="Victor",
			   Degree_ID=1,
			   Cafedra_ID=1,
			   Position_ID=1,
			   Discipline_ID=3,
			   Load_ID=4,
			   },
			   new Teacher{
			   Surname="Alexeev",
			   Second_Name="Alexandrovich",
			   Name="Artem",
			   Degree_ID=2,
			   Cafedra_ID=2,
			   Position_ID=2,	
			   Discipline_ID=3,	
			   Load_ID=4,
			   }

			};
			await context.Set<Teacher>().AddRangeAsync(teacher_test);	
			await context.SaveChangesAsync();
			var filter = new DisciplineTeacherFilter
			{
				TeacherID = 2
			};
			var disciplineResult = await disciplineService.GetDisciplinesByTeacherAsync(filter, CancellationToken.None);
			Assert.Equal(1, disciplineResult.Length);
		}

	}
}
