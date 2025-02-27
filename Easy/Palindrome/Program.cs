
Console.WriteLine(Run(121));
Console.WriteLine(Run(-121));
Console.WriteLine(Run(10));


static bool Run(int x)
{
    return x.ToString() == string.Join(string.Empty, x.ToString().Reverse());
}
