
using task1;

Cache<int> cache = new Cache<int>();
cache.Add(20);
cache.Add(1);
cache.Add(2);
cache.Add(3);
cache.Add(4);
cache.Add(5);
cache.Add(6);
cache.Add(7);
cache.Add(8);
cache.Add(9);
cache.Add(10);
cache.Remove(20);

foreach (var item in cache.Get())
{
    System.Console.Write(item + " ");
}

Cache<string> cache1 = new Cache<string>();
cache1.Add("apple");
cache1.Add("pineapple");
cache1.Add("grape");
cache1.Add("banana");
cache1.Add("pear");
cache1.Remove("pear");

foreach (var item in cache1.Get())
{
    System.Console.Write(item + " ");
}