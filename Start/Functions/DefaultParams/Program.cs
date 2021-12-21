using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix = "")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hello There!");

// TODO: Call with named params
PrintWithPrefix(thestr: "Hello There!", prefix: "Why");
PrintWithPrefix(prefix: "Why", thestr: "Hello There!");

