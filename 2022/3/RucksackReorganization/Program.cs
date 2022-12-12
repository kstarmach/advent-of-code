/// Part One ///

int result = 0;
foreach (var item in System.IO.File.ReadLines(@".\input.txt"))
{

    var firstPart = item.Substring(0, (int)(item.Length / 2));
    var secondPart = item.Substring((int)(item.Length / 2), (int)(item.Length / 2));

    foreach (var letter in firstPart)
    {
        if (secondPart.Contains(letter))
        {
            if (Char.IsLower(letter))
            {
                var letterByte = Math.Abs(Convert.ToByte(letter) - 96);
                result += letterByte;
            }
            else
            {
                var letterByte = Math.Abs(Convert.ToByte(letter) - 38);
                result += letterByte;
            }
            break;
        }
    }
}

System.Console.WriteLine("Part One result: " + result);

/// Part Two ///

int count_to_three = 0;
List<string> temp = new List<string>();
int result_two = 0;
foreach (var item in System.IO.File.ReadLines(@".\input.txt"))
{
    count_to_three++;
    temp.Add(item);


    if (count_to_three == 3)
    {
        foreach (var c in temp[0])
        {
            if (temp[1].Contains(c) && temp[2].Contains(c))
            {
                if (Char.IsLower(c))
                {
                    var letterByte = Math.Abs(Convert.ToByte(c) - 96);
                    result_two += letterByte;
                }
                else
                {
                    var letterByte = Math.Abs(Convert.ToByte(c) - 38);
                    result_two += letterByte;
                }
                break;
            }
        }

        count_to_three = 0;
        temp.Clear();
    }

}

System.Console.WriteLine("Part Two Result " + result_two);

