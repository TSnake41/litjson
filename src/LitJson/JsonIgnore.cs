#region Header
/**
 * JsonMapper.cs
 *   JSON to .Net object and object to JSON conversions.
 *
 * The authors disclaim copyright to this source code. For more details, see
 * the COPYING file included with this distribution.
 **/
#endregion


using System;

namespace LitJson
{
    [AttributeUsage(AttributeTargets.Field| AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class JsonIngoreAttribute : Attribute
    {

    }
}