using System;

namespace Penguin.Cms.Abstractions.Attributes
{
    /// <summary>
    /// Specifies that during dynamic display, this property should be treated as a different type
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayTypeAttribute : Attribute
    {
        /// <summary>
        /// The FullName of the type to treat this property as
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Creates a new instance of this attribute
        /// </summary>
        /// <param name="name">The full name of the type to render this property as</param>
        public DisplayTypeAttribute(string name)
        {
            this.Name = name;
        }
    }
}