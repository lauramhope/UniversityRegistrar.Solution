using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string EnrollmentDate { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}