namespace testCsharp;

public class TestSelectVsSelectMany
{
    public record Person(string Name, int Age, List<string> Friends);

    public static void Run()
    {
        var persons = new List<Person>
        {
            new Person("Apple", 1, new List<string> { "AA", "AB" }),
            new Person("Brad", 2, new List<string> { "BB", "BC" }),
            new Person("Cody", 3, new List<string> { "CC", "CD" }),
        };

        var _select = persons.Select(x => x.Friends);
        var _selectMany = persons.SelectMany(x => x.Friends);

        var _selectTuple = persons.Select(x => (Name: x.Name, Age: x.Age)).ToList();

        foreach (var x in _select)
        {
            Console.WriteLine(x);
        }

        foreach (var x in _selectMany)
        {
            Console.WriteLine(x);
        }

        foreach (var x in _selectTuple)
        {
            Console.WriteLine($"Name: {x.Name}, Age: {x.Age}");
        }

        /*
         * Output
         * _select:
         * System.Collections.Generic.List`1[System.String]
         * System.Collections.Generic.List`1[System.String]
         * System.Collections.Generic.List`1[System.String]
         *
         * _selectMany:
         * AA
         * AB
         * BB
         * BC
         * CC
         * CD
         *
         * _selectTuple:
         * Name: Apple, Age: 1
         * Name: Brad, Age: 2
         * Name: Cody, Age: 3
         */
    }
}