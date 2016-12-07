# C# Language Features & Tips

[![Build status](https://ci.appveyor.com/api/projects/status/1jlutgcdx1hd5rkw?svg=true)](https://ci.appveyor.com/project/scalefocus/csharp-features)
[![Gitter](https://badges.gitter.im/ScaleFocus/csharp-features.svg)](https://gitter.im/ScaleFocus/csharp-features?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

A collection of C# language features and tips samples.

## C# release history

|Version	Release| Date	   |     Tool	         |
| ------------- |:--------:| ------------------:|
|   1.0         |  2002    | 	Visual Studio     |
|   2.0         |  2005    | Visual Studio 2005 |
|   3.0         |  2008    | Visual Studio 2008 |
|   4.0         |  2010    | Visual Studio 2010	|
|   5.0         |  2012    | Visual Studio 2012 |
|   6.0         |  2015    | Visual Studio 2015 |

## C# 6 Language Features

1.  [Auto-property Enhancements](src/ScaleFocus.CSharp.Features/AutoPropertyEnhancements.cs)
2.  [Expression Bodied Methods and Auto-Properties](src/ScaleFocus.CSharp.Features/ExpressionBodiedMembers.cs)
3.  [The nameof Expressions](src/ScaleFocus.CSharp.Features/NameofExpressions.cs)
4.  [Null-conditional Operators](src/ScaleFocus.CSharp.Features/NullConditionalOperators.cs)
5.  [String Interpolation](src/ScaleFocus.CSharp.Features/StringInterpolation.cs)
6.  [Index Initializers](src/ScaleFocus.CSharp.Features/IndexInitializers.cs)
7.  [Using Static](src/ScaleFocus.CSharp.Features/UsingStatic.cs)
8.  [Exception Filters](src/ScaleFocus.CSharp.Features/ExceptionFilters.cs)
9.  [Await in Catch and Finally Blocks](src/ScaleFocus.CSharp.Features/AwaitInCatchFinally.cs)
10. [Default Constructors in Structs](src/ScaleFocus.CSharp.Features/StructDefaultContructor.cs)

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
1.  Tuples
2.  Pattern matching
1.  Record types
1.  Non-nullable reference types
5. Local Functions
5. Immutable Types

Full list of features as described in msdn: https://blogs.msdn.microsoft.com/dotnet/2016/08/24/whats-new-in-csharp-7-0/

## C# / .Net General discussion suggestions

Threads 
- Lock vs Mutex vs Semaphore: When to use & Performance;
- Perhaps also look at System.Threading.Timer;

Performance of abstractions on loops: https://www.infoq.com/articles/For-Each-Performance

## Contribute

Check out the [contribution guidelines](https://github.com/scalefocus/csharp-features/blob/master/CONTRIBUTING.md) if you want to contribute to this project.

## License

[Apache-2.0](https://github.com/scalefocus/csharp-features/blob/master/LICENSE)