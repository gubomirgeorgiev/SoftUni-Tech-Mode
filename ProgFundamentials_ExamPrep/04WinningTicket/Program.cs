using System;
using System.Text.RegularExpressions;


class _04WinningTicket
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }
        , StringSplitOptions.RemoveEmptyEntries);
        string pattern = "(\\${6,10})|(\\@{6,10})|(\\^{6,10})|(\\#{6,10})";
        //Regex regex = new Regex(pattern);
        if (input.Length == 0)
        {
            Console.WriteLine("invalid ticket");
        }
        else
        {
            foreach (string ticket in input)
            {
                if (ticket.Length == 20)
                {
                    MatchCollection match = Regex.Matches(ticket, pattern);
                    if (match.Count == 2 && match[0].Value[0] == match[1].Value[0])
                    {
                        if (GetShorterMatch(match[0].Value, match[1].Value) == 10)
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - {GetShorterMatch(match[0].Value, match[1].Value)}{match[0].Value[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - {GetShorterMatch(match[0].Value, match[1].Value)}{match[0].Value[0]}");
                        }
                    }
                    else if (match.Count > 2)
                    {
                        if (match[0].Value[0] == match[1].Value[0])
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - {GetShorterMatch(match[0].Value, match[1].Value)}{match[0].Value[0]}");
                        }
                        else if (match[0].Value[0] == match[2].Value[0])
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - {GetShorterMatch(match[0].Value, match[2].Value)}{match[0].Value[0]}");
                        }
                        else
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - {GetShorterMatch(match[0].Value, match[2].Value)}{match[2].Value[0]}");
                        }

                    }
                    else
                    {
                        Console.WriteLine($@"ticket ""{ticket}"" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
                
            }
        }
    }
    private static int GetShorterMatch(string one, string two)
    {
        int output = 0;
        if (one.Length > two.Length)
        {
            output = two.Length;
        }
        else if (one.Length < two.Length)
        {
            output = one.Length;
        }
        else
        {
            output = two.Length;
        }
        return output;
    }
}


