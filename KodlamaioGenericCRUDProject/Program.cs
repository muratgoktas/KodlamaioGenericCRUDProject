using KodlamaioGenericCRUDProject.Businees.Concrete;
using KodlamaioGenericCRUDProject.DataAccess.Abstract;
using KodlamaioGenericCRUDProject.DataAccess.Concrete;

InMemoryCourseDal courseDal = new InMemoryCourseDal();
CourseManager courseManager = new CourseManager(courseDal);

var Liste = courseManager.GetAll(); 

foreach (var item in Liste)
{
    Console.WriteLine(item.Name);
}