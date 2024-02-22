using System.CommandLine;
using System.CommandLine.Parsing;

var verbose = new Option<bool>(
    aliases: ["--verbose", "-v"],
       description: "Enable verbose output.");

var name = new Option<string>(
    aliases: ["--name", "-n"],
    description: "Name input.")
{
    IsRequired = true,
};

var birthDate = new Option<DateTime?>(
    aliases: ["--birth", "-b"],
    description: "Birth date input.");

var favoriteColor = new Option<Color>(
    aliases: ["--color", "-c"],
    description: "Favorite color.",
    getDefaultValue: () => Color.Red);

var rootCommand = new RootCommand("Parameter binding example")
{
    name,
    birthDate,
    verbose,
    favoriteColor
};

rootCommand.SetHandler(
    (verbose, name, birthDate, favoriteColor) =>
    {
        if(verbose)
        {
            Console.WriteLine($"Your name is {name}");
            if (birthDate is not null) Console.WriteLine($"Your birth date is {birthDate:D}");
            Console.WriteLine($"Your favorite color is: {favoriteColor}");
        }
        else
        {
            Console.WriteLine($"Name: {name}");
            if (birthDate is not null) Console.WriteLine($"Birth date: {birthDate:d}");
            Console.WriteLine($"Favorite color: {favoriteColor}");
        }
    },
    verbose, name, birthDate, favoriteColor);


await rootCommand.InvokeAsync(args);

internal enum Color
{
    Red,
    Blue,
    Green,
    Yellow,
    Purple,
    Orange
}