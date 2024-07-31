using Microsoft.Extensions.Logging;
using Practice5_MySerializer;
using System.Runtime.Serialization;

namespace Practice5_TestClassesReflection
{
    internal class Program
    {
        private const string FILENAME = "serealized.json";

        private static void Main(string[] args)
        {
            ILogger logger = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Error);
            }).CreateLogger<Program>();

            Student studentVlad = new Student("Vlad", 19, new Dictionary<string, int>() { { "Math", 4 }, { "History", 3 }, { "IT", 5 } });
            Student studentKirill = new Student("Kirill", 22, new Dictionary<string, int>() { { "Math", 5 }, { "History", 4 } });
            University university = new University("HSE", new List<Student>() { studentVlad, studentKirill }, studentVlad);
            Console.WriteLine(university.ToString());
            MySerializer mySerializer = new MySerializer(university.GetType());

            File.WriteAllText(FILENAME, mySerializer.Serialize(university));
            Console.WriteLine("Serialized!");
            string json = File.ReadAllText(FILENAME);
            Console.WriteLine("Deserialized JSON:");
            try
            {
                University? uni = (University?)mySerializer.Deserialize<University>(json);
                Console.WriteLine(uni?.ToString());
            }
            catch (SerializationException e)
            {
                logger.LogError(e, e.Message);
            }
        }
    }
}