// string? x = null;
// int? length = x?.Length;
// // null length, will return nothing
// System.Console.WriteLine($"Length: {length}");

// // now has a value, will return a number of 9
// x = "Some text";
// length = x?.Length;
// System.Console.WriteLine($"New Length: {length}");

// // assign anohter null value to the same variable
// // null length, will return nothing
// int? y = null;
// length = y;
// System.Console.WriteLine($"Yet another Length: {length}");

using System.ComponentModel.Design;
using System.Net;

string? x = null;
if (x is null)
{
    System.Console.WriteLine("I am allowed to be null, because of the setting");
}



// (string country, string capital, double gdpPerCapital) = ("Slovenia", "Ljubljana", 123.456);
// System.Console.WriteLine($"{capital} is the the capital of {country} with a GDP of: ${gdpPerCapital}");

// // assign a tuple to individually declared variables that are pre-declared
// string country;
// string capital;
// double gdpPerCapital;
// (country, capital, gdpPerCapital) = ("Slovenia", "Ljubljana", 123.456);
// System.Console.WriteLine($"{capital} is the the capital of {country} with a GDP of: ${gdpPerCapital}");

// // assign a tuple to individually declared and implicity typed variables
// (var country, var capital, var gdpPerCapita) = ("Slovenia", "Ljubljana", 123.456);
// System.Console.WriteLine($"{capital} is the the capital of {country} with a GDP of: ${gdpPerCapita}");

// // assign a tuple to individually declared variables that are implicitly typed with a distributive syntax
// var (country, capital, gdpPerCapita) = ("Slovenia", "Ljubljana", 123.546);

// // 5.) declare a name item tuple and assign it tuple values, then access the tuple items by name
// (string Name, string Capital, double GdpPerCapita) countryInfo = ("Slovenia", "Ljubljana", 123.456);
// System.Console.WriteLine($"{countryInfo.Name} is the capital {countryInfo.Capital} with a GDP of: {countryInfo.GdpPerCapita}");

// // 6.) assign a named item tuple to a single implicitly type variable that is implicitly typed, and then access the tuple items by name
// var countryInfo = (Name: "Slovenia", Capital: "Ljubljana", GdpPerCapita: 123.456);
// System.Console.WriteLine($"{countryInfo.Name} is the capital of {countryInfo.Capital} with a GDP of: ${countryInfo.GdpPerCapita}");

// // 7.) assign an unnamed tuple to a single implicitly typed variablem then access the tuple elements by their item-number property
// var countryInfo = ("Slovenia", "Ljubljana", 123.456);
// System.Console.WriteLine($"{countryInfo.Item2} is the capital of {countryInfo.Item1} with a GDP of: ${countryInfo.Item3}");

// // 8.) assign a named item tuple to a single implicitly typed variable, then access the tuple items by their iterm-number property
// var countryInfo = (Name: "Slovenia", Capital: "Ljubljana", GdpPerCapita: 123.456);
// System.Console.WriteLine($"{countryInfo.Capital} is the capital of {countryInfo.Name} with a GDP of: ${countryInfo.GdpPerCapita}");

// // 9.) discard portions of the tuple with underscores
// (string name, _, double gdpPerCapita) = ("Slovenia", "Ljubljana", 123.456);

// // 10.) tuple element names can be inferred from variable and property names
// string country = "Slovenia";
// string capital = "Ljubljana";
// double gdpPerCapita = 123.456;
// var countryInfo = (country, capital, gdpPerCapita);
// System.Console.WriteLine($"{countryInfo.capital} is the capital of {countryInfo.country} with a GDP of: ${countryInfo.gdpPerCapita}");










