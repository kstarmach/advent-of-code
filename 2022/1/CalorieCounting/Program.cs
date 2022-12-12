/// Part One ///
List<int> answer = new List<int>();

int temp = 0;

foreach (var item in System.IO.File.ReadLines(@".\input.txt"))
{
    if (int.TryParse(item, out int bar))
    {
        temp += bar;
    }
    else
    {
        answer.Add(temp);
        temp = 0;
    }
}

System.Console.WriteLine("Part One Answer: " + answer.Max());

/// Part Two ///

System.Console.WriteLine("Part Two Answer: " + answer.OrderByDescending(x => x).Take(3).Sum());