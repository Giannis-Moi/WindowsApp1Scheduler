using System.Collections.Generic;
using UniversityApp.Base;


namespace UniversityApp.Implementation {
    public class Professor : Person {
        
        public short Age { get; set; }
        public ProfessorRankEnum Rank { get; set; }
        public List<CoursesCategoryEnum> AssignedCourses { get; set; }


    }
}
