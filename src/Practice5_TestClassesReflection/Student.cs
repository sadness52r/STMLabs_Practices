using Practice5_MySerializer;

namespace Practice5_TestClassesReflection
{
    [SerializableAttribute]
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

    }
}
