/// Part One ///

int result = 0;
foreach (var line in System.IO.File.ReadLines(@"./input.txt"))
{
    List<int> r = line.Split('-', ',').Select(Int32.Parse).ToList();

    if (r[0] <= r[2] && r[1] >= r[3] || r[2] <= r[0] && r[3] >= r[1])
    {
        result++;
    }

}
System.Console.WriteLine("Part One Result: " + result);

/// Part Two ///

int resultTwo = 0;
foreach (var line in System.IO.File.ReadLines(@"./input.txt"))
{
    List<int> r = line.Split('-', ',').Select(Int32.Parse).ToList();


    if ((r[0] <= r[2] && r[1] >= r[2]) || (r[2] <= r[0] && r[3] >= r[0]))
    {
        System.Console.WriteLine(line);
        resultTwo++;
    }

}
System.Console.WriteLine("Part Two Result: " + resultTwo);