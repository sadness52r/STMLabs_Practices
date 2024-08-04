using Practice5_MySerializer;
using System.Text;

namespace Practice5_TestClassesReflection
{
    internal class Student
    {
        private string name;
        private int age;
        private Dictionary<string, int> marks;

        [JsonNameAttribute("Student name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [IgnoreAttribute]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        [JsonNameAttribute("Marks")]
        public Dictionary<string, int> Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public Student() : this(string.Empty, -1, new Dictionary<string, int>()) { }
        public Student(string name, int age, Dictionary<string, int> marks)
        {
            this.name = name;
            this.age = age;
            this.marks = marks;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Student name: {name}\n\tAge: {age}\n\tMarks:\n\t\t");
            foreach (var item in marks)
            {
                stringBuilder.Append($"{item.Key} - {item.Value}\n\t\t");
            }
            return stringBuilder.ToString();
        }
    }
}
