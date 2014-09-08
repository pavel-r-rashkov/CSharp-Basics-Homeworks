using System;

class StringsAndObjects
{
    static void Main()
    {
        string helloWord = "Hello";
        string worldWord = "World";
        object helloWorld = helloWord + " " + worldWord;
        string greeting = (string)helloWorld;
    }
}

