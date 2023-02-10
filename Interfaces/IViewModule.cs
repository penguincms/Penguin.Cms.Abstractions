namespace Penguin.Cms.Abstractions.Interfaces
{
    public interface IViewModule<out T>
    {
        T Model { get; }

        string Name { get; }

        string ViewPath { get; }
    }
}