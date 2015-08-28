using System;

namespace LitJson
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class JsonIgnoreAttribute : Attribute
    {

    }
}
