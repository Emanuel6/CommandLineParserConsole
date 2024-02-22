using CommandLine;

namespace CommandLineParserConsole;

internal class Options
{
    [Option('v', "verbose", Required = false, HelpText = "Enable verbose output.")]
    public bool Verbose { get; set; }

    [Option('n', "name", Required = true, HelpText = "Name input.")]
    public required string Name { get; set; }

    [Option('b', "birth", Required = false, HelpText = "Birth date input.")]
    public DateTime? BirhtDate { get; set; }

    [Option('c', "color", Required = false, Default = Color.Red, HelpText = "Favorite color.")]
    public Color FavoriteColor { get; set; }
}

internal enum Color
{
    Red,
    Blue,
    Green,
    Yellow,
    Purple,
    Orange
}
