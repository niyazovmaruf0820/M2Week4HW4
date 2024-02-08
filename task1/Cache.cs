namespace task1;

public class Cache<T>
{
    List<T> values = new List<T>();
    public void Add(T value)
    {
        values.Add(value);
    }
    public List<T> Get()
    {
        return values;
    }
    public void Remove(T value)
    {
        values.Remove(value);
    }
}



// public static class Cache<T>
// {
//     public static void Add(List<T> values,T value)
//     {
//         values.Add(value);
//     }
//     public static List<T> Get(List<T> values)
//     {
//         return values;
//     }
//     public static void Remove(List<T> values,T value)
//     {
//         values.Remove(value);
//     }
// }
