using Newtonsoft.Json;
using Practice5_MySerializer;
using System.Text.Json;

namespace Practice5_TestClassesReflection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student studentVlad = new Student("Vlad", 19, new Dictionary<string, int>() { { "Math", 4 }, { "History", 3 }, { "IT", 5 } });
            Student studentKirill = new Student("Kirill", 22, new Dictionary<string, int>() { { "Math", 5 }, { "History", 4 } });
            University university = new University("HSE", new List<Student>() { studentVlad, studentKirill }, studentVlad);
            MySerializer mySerializer = new MySerializer(university.GetType());

            var json = mySerializer.Serialize(university);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);
            //var jsonObj = JsonConvert.DeserializeObject(json);
            //Console.WriteLine(JsonConvert.SerializeObject(jsonObj, Formatting.Indented));
            Console.WriteLine("Deserialized JSON:");
            University uni = (University)mySerializer.Deserialize<University>(json);

        }
    }
}