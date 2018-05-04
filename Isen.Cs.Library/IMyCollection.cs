namespace Isen.Cs.Library
{
    public interface IMyCollection
    {
        int Count { get; }
        string[] Values { get; }
        void Add(string item);

        void InsertAt(int index, string item);
        void RemoveAt(int index);
    }
}