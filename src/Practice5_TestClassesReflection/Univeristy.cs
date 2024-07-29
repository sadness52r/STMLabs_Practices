using Practice5_MySerializer;

namespace Practice5_TestClassesReflection
{
    [SerializableAttribute]
    internal class University
    {
        private string title;
        private List<Student> students;
        private Student bestStudent;

        [JsonNameAttribute("University Title")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [JsonNameAttribute("Students")]
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        [JsonNameAttribute("Best")]
        public Student BestStudent
        {
            get { return bestStudent; }
            set { bestStudent = value; }
        }

        public University() : this(string.Empty, new List<Student>(), new Student()){}
        public University(string title, List<Student> students, Student bestStudent)
        {
            this.title = title;
            this.students = students;
            this.bestStudent = bestStudent;
        }
    }
}
