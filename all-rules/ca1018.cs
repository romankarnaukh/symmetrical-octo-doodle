using System;

namespace ca1018
{
    // Violates rule: MarkAttributesWithAttributeUsage.
    public sealed class BadCodemastertainerAttribute : Attribute
    {
        public BadCodemastertainerAttribute(string developerName)
        {
            DeveloperName = developerName;
        }
        public string DeveloperName { get; }
    }

    // Satisfies rule: Attributes specify AttributeUsage.
    // This attribute is valid for type-level targets.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
    public sealed class GoodCodemastertainerAttribute : Attribute
    {
        public GoodCodemastertainerAttribute(string developerName)
        {
            DeveloperName = developerName;
        }
        public string DeveloperName { get; }
    }
}
