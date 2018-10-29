# Handy extensions for nanoFramework

Provides a set of class extensions and extended classes to help improve compatibility with existing C# code
In the future, some of these extensions may become obsolete (and removed) if the equivalent code is implmented in mscorlib 

## Namespaces
### nanoFramework.Contrib.HandyExtensions.StringExtensions
#### StringEx class
This class contains the static compatibility methods for the string class. They should work exactly like the standard 
static methods on the Microsoft CoreCLR string object.

See the [Microsoft System.String reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netcore-2.1}

#### System.string extension methods
StringEx.IsNullOrEmpty(string): 
Tests if the string is either NULL or String.Empty

See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=netcore-2.1}

StringEx.IsNullOrWhitespace(string): 
Tests if the string is either NULL, String.Empty or composed of only whitespace characters

See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=netcore-2.1}

#### System.string extension methods
isNullOrEmpty(): 
An instance helper for StringEx.IsNullOrEmpty. (Can be called on a null object)
Note: This is a non-standard method

isNullOrWhitespace(): 
An instance helper for StringEx.IsNullOrWhitespace. (Can be called on a null object)
***Note: This is a non-standard method***

StartsWith(string): 
Determines whether the beginning of this string instance matches a specified string.
See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith?view=netcore-2.1}

StartsWith(char): 
Determines whether the first character of this string instance matches a specified character.
See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith?view=netcore-2.1}

EndsWith(string): 
Determines whether the end of this string instance matches a specified string.
See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netcore-2.1}

EndsWith(char): 
Determines whether the last character of this string instance matches a specified character.
See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netcore-2.1}

Replace(string oldValue,string newValue): 
Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.replace?view=netcore-2.1}

Replace(char oldValue,char newValue): 
Returns a new string in which all occurrences of a specified character in the current instance are replaced with another specified character.
See the [Microsoft reference]{https://docs.microsoft.com/en-us/dotnet/api/system.string.replace?view=netcore-2.1}

### nanoFramework.Contrib.HandyExtensions.TimeExtensions
Provides System.DateTime and System.TimeSpan related extensions and helper methods

#### DateTimeEx class
To be documented.

#### DateTimeEx class
To be documented.

#### System.DateTime extension methods
To be documented.

### Exception
Provides System.Exception related extensions and helper methods

#### System.Exception extension methods
To be documented.


## Using the extensions

Add this NuGet package to your project: `nanoFramework.Extensions.HandyExtensions`.

Contributor: [Sixsmith](https://github.com/alvahdean)
