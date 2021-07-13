namespace UniversityApp.Base {
    public class Person : Entity {
        public string Name { get; set; }
        public string Surname { get; set; }


        public string GetFullName() {

            return string.Format("{0}  {1}", Name, Surname);
        }



    }


}


    





