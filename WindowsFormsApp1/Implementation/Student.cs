using System.Collections.Generic;
using UniversityApp.Base;

namespace UniversityApp.Implementation {
    public class Student : Person {
        public string RegistrationNumber { get; set; }
        public int Age { get; set; }
        public List<CoursesCategoryEnum> AppliedCategories { get; set; }
    }
}
