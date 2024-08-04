namespace Practice5_MySerializer
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class JsonNameAttribute : Attribute
    {
        private readonly string name;

        public string Name => name;

        public JsonNameAttribute(string name)
        {
            this.name = name;
        }
    }
}
