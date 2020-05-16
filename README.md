# abcdefghijklmnopqrstuvwxyz
abcdefghijklmnopqrstuvwxyz is a library providing all alphabets in the modern english language.

## Installation
```ps
Install-Package abcdefghijklmnopqrstuvwxyz
```
## Example Usage

```cs
using System;
using abcdefghijklmnopqrstuvwxyz;

public static class Program
{
  public static void Main()
    => Console.WriteLine(AlphabetProvider.GetAlphabet());
}
```