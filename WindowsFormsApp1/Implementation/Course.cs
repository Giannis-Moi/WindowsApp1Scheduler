using UniversityApp.Base;

namespace UniversityApp.Implementation {
    public class Course : Entity {
        public string Code { get; set; }
        public string Subject { get; set; }
        public int Hours { get; set; }
        public CoursesCategoryEnum Category { get; set; }

        public Course() {

        }

    }
}
