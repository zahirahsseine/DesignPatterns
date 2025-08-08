var s1 = Logger.Instance;
var s2 = Logger.Instance;

s1.Log("Hello");
s2.Log("World");

Console.WriteLine(s1 == s2); // True — same instance
