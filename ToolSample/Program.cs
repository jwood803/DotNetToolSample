var command = args[0];
var input = string.Join(" ", args.Skip(1));

switch (command)
{
    case "encode":
        var encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
        Console.WriteLine(encoded);
        break;
    case "decode":
        var decoded = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
        Console.WriteLine(decoded);
        break;
    default:
        break;
}