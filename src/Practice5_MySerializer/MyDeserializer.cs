using System.Collections;
using System.Reflection;
using System.Text.Json;

namespace Practice5_MySerializer
{
    public partial class MyJsonConverter
    {
        private static object? DeserializeObject(JsonElement jsonElement, Type? type, Type[]? innerTypes = null)
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
            if (type.IsEnum)
            {
                return Enum.Parse(type, jsonElement.GetString());
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
        private static object? DeserializeIDictionary(JsonElement jsonElement, Type? type, Type[]? innerTypes)
        {
            Type dicType = typeof(Dictionary<,>).MakeGenericType(innerTypes);
            var dict = (IDictionary?)Activator.CreateInstance(dicType);
            foreach (var item in jsonElement.EnumerateObject())
            {
                object key = item.Name;
                object? deserializedVal = DeserializeObject(item.Value, item.Value.GetType());
                dict?.Add(Convert.ChangeType(key, innerTypes[0]), Convert.ChangeType(deserializedVal, innerTypes[1]));
            }
            return dict;
        }
        private static object? DeserializeIEnumerable(JsonElement jsonElement, Type? type, Type innerType)
        {
            Type listType = typeof(List<>).MakeGenericType(innerType);
            var array = (IList?)Activator.CreateInstance(listType);
            foreach (var item in jsonElement.EnumerateArray())
            {
                array?.Add(DeserializeObject(item, innerType));
            }
            return array;
        }
        private static object? DeserializeConcreteObject(JsonElement jsonElement, Type type)
        {
            object? obj = Activator.CreateInstance(type);
            var props = type.GetProperties().Where(p => p.GetCustomAttribute<IgnoreAttribute>() == null).ToArray();
            foreach (var prop in props)
            {
                string jsonPropertyName = prop.GetCustomAttribute<JsonNameAttribute>()?.Name ?? prop.Name;
                JsonElement propElement = jsonElement.GetProperty(jsonPropertyName);
                prop.SetValue(obj, Convert.ChangeType(DeserializeObject(propElement, prop.PropertyType, prop.PropertyType.GetGenericArguments()), prop.PropertyType));
            }
            return obj;
        }
        private static bool CheckPrimitiveType(JsonElement jsonElement, Type? type, out object? val)
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

        public static object? Deserialize<T>(string json)
        {
            using (JsonDocument jsonDocument = JsonDocument.Parse(json))
            {
                return DeserializeObject(jsonDocument.RootElement, typeof(T));
            }
        }
    }
}
