using CommandLine;
using CommandLineParserConsole;

Parser.Default.ParseArguments<Options>(args)
    .WithParsed(options =>
    {
        if (options.Verbose)
        {
            Console.WriteLine($"Your name is {options.Name}");
            if (options.BirhtDate is not null) Console.WriteLine($"Your birth date is {options.BirhtDate:D}");
            Console.WriteLine($"Your favorite color is: {options.FavoriteColor}");
        }
        else
        {
            Console.WriteLine($"Name: {options.Name}");
            if (options.BirhtDate is not null) Console.WriteLine($"Birth date: {options.BirhtDate:d}");
            Console.WriteLine($"Favorite color: {options.FavoriteColor}");
        }
    });
;