namespace Penguin.Cms.Abstractions
{
    public class Macro
    {
        public string DisplayGroup { get; set; }

        public string DisplayName { get; set; }

        public Macro(string displayGroup, string displayName)
        {
            DisplayGroup = displayGroup;
            DisplayName = displayName;
        }
    }
}