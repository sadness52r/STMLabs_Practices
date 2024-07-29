using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Practice5_MySerializer
{
    public class MySerializer
    {
        public MySerializer(Type type)
        {
            if (!type.IsDefined(typeof(SerializableAttribute), false))
            {
                throw new SerializationException("The type has not necessary serializable attribute!");
            }
        }

        private string SerializeArray(Array array)
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
        private string SerializeIEnumerable(IEnumerable iEnumerable)
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
        private string SerializeIDictionary(IDictionary dictionary)
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
        private string SerializeObject(object obj)
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
        private object? DeserializeObject(JsonElement jsonElement, Type? type, Type[] innerTypes = null)
        {
            if (jsonElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (jsonElement.ValueKind == JsonValueKind.String)
            {
                return jsonElement.GetString();
            }
            if (CheckPrimitiveType(jsonElement, type, out object? val))
            {
                return val;
            }
            if (typeof(IDictionary).IsAssignableFrom(type))
            {
                return DeserializeIDictionary(jsonElement, type, innerTypes);
            }
            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return DeserializeIEnumerable(jsonElement, type, type.GetGenericArguments()[0]);
            }
            return DeserializeConcreteObject(jsonElement, type);
        }
        private object? DeserializeIDictionary(JsonElement jsonElement, Type type, Type[] innerTypes)
        {
            Type dicType = typeof(Dictionary<,>).MakeGenericType(innerTypes);
            var dict = (IDictionary)Activator.CreateInstance(dicType);
            foreach (var item in jsonElement.EnumerateObject())
            {
                object key = item.Name;
                object deserializedVal = DeserializeObject(item.Value, item.Value.GetType());
                dict.Add(Convert.ChangeType(key, innerTypes[0]), Convert.ChangeType(deserializedVal, innerTypes[1]));
            }
            return dict;
        }
        private object DeserializeIEnumerable(JsonElement jsonElement, Type type, Type innerType)
        {
            Type listType = typeof(List<>).MakeGenericType(innerType);
            var array = (IList)Activator.CreateInstance(listType);
            foreach (var item in jsonElement.EnumerateArray())
            {
                array.Add(DeserializeObject(item, innerType));
            }
            return array;
        }
        private object? DeserializeConcreteObject(JsonElement jsonElement, Type type)
        {
            object? obj = Activator.CreateInstance(type);
            var props = type.GetProperties().Where(p => p.GetCustomAttribute<IgnoreAttribute>() == null).ToArray();
            foreach (var prop in props)
            {
                string jsonPropertyName = prop.GetCustomAttribute<JsonNameAttribute>()?.Name ?? prop.Name;
                JsonElement propElement = jsonElement.GetProperty(jsonPropertyName);
                prop.SetValue(obj, DeserializeObject(propElement, prop.PropertyType, prop.PropertyType.GetGenericArguments()));
            }
            return obj;
        }
        private bool CheckPrimitiveType(JsonElement jsonElement, Type? type, out object? val)
        {
            if (type == typeof(int))
            {
                val = jsonElement.GetInt32();
            }
            else if (type == typeof(double))
            {
                val = jsonElement.GetDouble();
            }
            else if (type == typeof(float))
            {
                val = jsonElement.GetSingle();
            }
            else if (type == typeof(decimal))
            {
                val = jsonElement.GetDecimal();
            }
            else if (type == typeof(bool))
            {
                val = jsonElement.GetBoolean();
            }
            else
            {
                val = null;
                return false;
            }
            return true;
        }

        public string Serialize(object? obj)
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
        public object? Deserialize<T>(string json)
        {
            using (JsonDocument jsonDocument = JsonDocument.Parse(json))
            {
                return DeserializeObject(jsonDocument.RootElement, typeof(T));
            }
        }
    }
}
