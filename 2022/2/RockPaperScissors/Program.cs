/// Part One ///
int total_score = 0;
int total_score_two = 0;
foreach (var item in System.IO.File.ReadLines(@".\input.txt"))
{
    switch (item)
    {
        case "A X":
            total_score += 4;
            total_score_two += 3;
            break;
        case "A Y":
            total_score += 8;
            total_score_two += 4;
            break;
        case "A Z":
            total_score += 3;
            total_score_two += 8;
            break;
        case "B X":
            total_score += 1;
            total_score_two += 1;
            break;
        case "B Y":
            total_score += 5;
            total_score_two += 5;
            break;
        case "B Z":
            total_score += 9;
            total_score_two += 9;
            break;
        case "C X":
            total_score += 7;
            total_score_two += 2;
            break;
        case "C Y":
            total_score += 2;
            total_score_two += 6;
            break;
        case "C Z":
            total_score += 6;
            total_score_two += 7;
            break;
    }
}

System.Console.WriteLine("Part One result: " + total_score);

/// Part Two ///
System.Console.WriteLine("Part Two result: " + total_score_two);