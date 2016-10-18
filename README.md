# C# Language Features & Tips

A collection of C# language features and tips samples.

## C# 6 Language Features

1.  Auto-property enhancements
2.  Expression-bodied function members
3.  Using static
4.  Null-conditional operators
5.  String interpolation
6.  nameof expressions
7.  Index initializers
8.  Exception filters
9.  Await in catch and finally blocks
10. Default constructors in structs

### Abondoned features 
 
*Primary Contructors* 
``` csharp
public class Person(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
}
```

*DeclarationExpressions*  
``` csharp
// Read number and print the power 2 of the number
if (int.TryParse(var line = Console.ReadLine(), out int i))
{
    Console.WriteLine("Result: {0}", (var x = i) * x, x);
}

// Convert list of strings to list of integers
var strings = new List<string> { "123", "-5", "1337", "3777" };
var numbers = from s in strings select int.TryParse(s, out int i) ? i : -1;
```

### Further readings
https://github.com/dotnet/roslyn/wiki/New-Language-Features-in-C%23-6
Some interesting point of view: http://sietch.net/ViewNewsItem.aspx?NewsItemID=250  

## C# 7 Features

Full list of features as described in msdn: https://blogs.msdn.microsoft.com/dotnet/2016/08/24/whats-new-in-csharp-7-0/

## C# / .Net General discussion suggestions

Threads 
- Lock vs Mutex vs Semaphore: When to use & Performance;
- Perhaps also look at System.Threading.Timer;

Performance of abstractions on loops: https://www.infoq.com/articles/For-Each-Performance
