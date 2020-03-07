namespace Penguin.Cms.Abstractions
{
    public class Macro
    {
        public string DisplayGroup { get; set; }

        public string DisplayName { get; set; }

        public Macro(string displayGroup, string displayName)
        {
            this.DisplayGroup = displayGroup;
            this.DisplayName = displayName;
        }
    }
}