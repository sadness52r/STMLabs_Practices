using Practice5_MySerializer;
using System.Text;

namespace Practice5_TestClassesReflection
{
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"University title: {title}\nStudents:\n\t");
            foreach (var student in students)
            {
                stringBuilder.Append(student.ToString() + "\n\t");
            }
            stringBuilder.Append($"\nBest student:\n\t{bestStudent.ToString()}");
            return stringBuilder.ToString();
        }
    }
}
