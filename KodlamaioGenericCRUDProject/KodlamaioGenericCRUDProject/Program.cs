using KodlamaioGenericCRUDProject.Businees.Concrete;
using KodlamaioGenericCRUDProject.DataAccess.Concrete.InMemory;

iMCourseDal courseDal = new iMCourseDal();
CourseManager courseManager = new CourseManager(courseDal);

var Liste = courseManager.GetAll(); 

foreach (var item in Liste)
{
    Console.WriteLine("Kurs İsimi : {0}",item.Name);
}

iMCategoryDal categoryDal = new iMCategoryDal();
CategoryManager categoryManager = new(categoryDal);

var Liste2 =categoryManager.GetAll();
foreach (var item in Liste2)
{
    Console.WriteLine(item.Name);
}
iMStudentDal studentDal = new iMStudentDal();
StudentManager studentManager = new(studentDal);
var Liste3 =studentManager.GetAll();
foreach (var item in Liste3)
{
    Console.WriteLine(item.FirstName + " " + item.LastName);
}

iMInstructorDal instructorDal =new iMInstructorDal();
InstructorManager instructorManager = new(instructorDal);
var Liste4 =instructorManager.GetAll();
foreach (var item in Liste4)
{
    Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Branch);
}

