using System;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace UniversityApp.Implementation {
    public class Storage {

        public const string _JsonFile = "UniversityData.json";
        
        public void Save(University university) {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(university);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }

        public University Load() {
            try {

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

                if (File.Exists(path)) {
                    string data = File.ReadAllText(path);

                    University university = serializer.Deserialize<University>(data);
                    return university;
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
            return null;
        }

    }
}
