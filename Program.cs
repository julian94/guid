Guid guid = Guid.NewGuid();
string version = "guid version 1.0.0";
string help = $"""
    {version}
    guid creates a Version 4 Universally Unique Identifier (UUID) as described in RFC 4122, Sec. 4.4.
    Options:
    -h|--help       This help.
    -v|--version    The version of guid.
    
    Print options
    d is the default option.
    n   {Compute(guid, ["n"])}
    d   {Compute(guid, ["d"])}
    b   {Compute(guid, ["b"])}
    p   {Compute(guid, ["p"])}
    x   {Compute(guid, ["x"])}
    N   {Compute(guid, ["N"])}
    D   {Compute(guid, ["D"])}
    B   {Compute(guid, ["B"])}
    P   {Compute(guid, ["P"])}
    X   {Compute(guid, ["X"])}
    """;

if (args.Length > 0 && args[0].StartsWith("-"))
{
    var output = NonGuid(args[0]);
    Console.WriteLine(output);
}
else
{
    var output = Compute(guid, args);
    Console.WriteLine(output);
}

string NonGuid(string input) => (input) switch
{
    "-v" => version,
    "--version" => version,
    "-h" => help,
    "--help" => help,
    _ => help,
};
string Compute(Guid g, string[] input) => (input) switch
{
    ["n"] => g.ToString("N"),
    ["d"] => g.ToString("D"),
    ["b"] => g.ToString("B"),
    ["p"] => g.ToString("P"),
    ["x"] => g.ToString("X"),
    ["N"] => g.ToString("N").ToUpper(),
    ["D"] => g.ToString("D").ToUpper(),
    ["B"] => g.ToString("B").ToUpper(),
    ["P"] => g.ToString("P").ToUpper(),
    ["X"] => g.ToString("X").ToUpper().Replace('X', 'x'),
    _ => g.ToString(),
};
