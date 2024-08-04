using System.Collections;
using System.Reflection;
using System.Text;

namespace Practice5_MySerializer
{
    public partial class MyJsonConverter
    {
        private static string SerializeArray(Array array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0 && i < array.Length - 1)
                {
                    sb.Append(",");
                }
                sb.Append(Serialize(array.GetValue(i)));
            }
            sb.Append("]");
            return sb.ToString();
        }
        private static string SerializeIEnumerable(IEnumerable iEnumerable)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            bool firstElement = true;
            foreach (var item in iEnumerable)
            {
                if (!firstElement)
                {
                    sb.Append(",");
                }
                sb.Append(Serialize(item));
                firstElement = false;
            }
            sb.Append("]");
            return sb.ToString();
        }
        private static string SerializeIDictionary(IDictionary dictionary)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            bool firstEntry = true;
            foreach (var key in dictionary.Keys)
            {
                if (!firstEntry)
                {
                    sb.Append(",");
                }
                sb.Append($"{Serialize(key)}:");
                sb.Append(Serialize(dictionary[key]));
                firstEntry = false;
            }
            sb.Append("}");
            return sb.ToString();
        }
        private static string SerializeObject(object obj)
        {
            StringBuilder sb = new StringBuilder();
            var properties = obj.GetType().GetProperties().Where(p => p.GetCustomAttribute<IgnoreAttribute>() == null).ToArray();
            sb.Append("{");
            bool firstProperty = true;
            foreach (var property in properties)
            {
                var jsonPropertyName = property.GetCustomAttribute<JsonNameAttribute>()?.Name ?? property.Name;
                if (!firstProperty)
                {
                    sb.Append(",");
                }
                sb.Append($"\"{jsonPropertyName}\":");
                var value = property.GetValue(obj);
                sb.Append(Serialize(value));
                firstProperty = false;
            }
            sb.Append("}");
            return sb.ToString();
        }

        public static string Serialize(object? obj)
        {
            if (obj == null)
            {
                return "null";
            }

            Type type = obj.GetType();
            if (type.IsPrimitive || obj is string)
            {
                return $"\"{obj}\"";
            }
            if (type.IsArray)
            {
                var array = (Array)obj;
                return SerializeArray(array);
            }
            if (typeof(IDictionary).IsAssignableFrom(type))
            {
                IDictionary dictionary = (IDictionary)obj;
                return SerializeIDictionary(dictionary);
            }
            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                IEnumerable iEnumerable = (IEnumerable)obj;
                return SerializeIEnumerable(iEnumerable);
            }
            return SerializeObject(obj);
        }
    }
}
