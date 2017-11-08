using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _4RoliThe_Coder
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<Events> events = new List<Events>();
        while (!input.Equals("Time for Code"))
        {
            string[] inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string id = inputArr[0];
            if (!events.Any(x => x.Id.Contains(id)))
            {
                if (inputArr[1][0] != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (inputArr.Length > 2)
                {
                    List<string> participants = new List<string>();
                    bool containsAt = true;
                    for (int i =2; i< inputArr.Length; i++)
                    {
                        if (inputArr[i][0] == '@')
                        {
                            participants.Add(inputArr[i]);
                        }
                        else
                        {
                            containsAt=false;
                        }
                    }
                    if (containsAt)
                    {
                        events.Add(new Events
                        {
                            Id = id,
                            EventName = inputArr[1].TrimStart('#'),
                            Participants = participants,
                            TempParticipants = new List<string>()
                        });
                        events.First(a => a.Id == id).CollectedParticipants();
                    }
                }
                else
                {
                    events.Add(new Events
                    {
                        Id = id,
                        EventName = inputArr[1].TrimStart('#'),
                        Participants = new List<string>(),
                        TempParticipants = new List<string>()
                    });
                    events.First(a => a.Id == id).CollectedParticipants();
                } 
            }
            else
            {
                if (inputArr[1][0] != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (events.Any(a => a.EventName == inputArr[1].TrimStart('#')))
                {
                    if (inputArr.Length > 2)
                    {
                        bool containsAt = true;
                        List<string> tempPparticipants = new List<string>();
                        for (int i = 2; i < inputArr.Length; i++)
                        {
                            if (inputArr[i][0] == '@'&& inputArr[i].Length>1)
                            {
                                tempPparticipants.Add(inputArr[i]);
                            }
                            else
                            {
                                containsAt=false;
                            }
                        }
                        if (containsAt)
                        {
                            events.First(a => a.Id == id).TempParticipants = tempPparticipants;
                            events.First(a => a.Id == id).CollectedParticipants();
                        } 
                    }
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
            }
            input = Console.ReadLine();
        }
        GetTheOutput(events);
    }

    private static void GetTheOutput(List<Events> events)
    {
        foreach (Events ev in events.OrderByDescending(a => a.Participants.Count()).ThenBy(a=>a.EventName))
        {
            Console.WriteLine($"{ev.EventName} - {ev.Participants.Count()}");
            if (ev.Participants.Count() > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, ev.Participants));
            }
        }
    }

    class Events
    {
        public string Id { get; set; }
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
        public List<string> TempParticipants { get; set; }
        public List<string> CollectedParticipants()
        {
            return Participants = Participants.Concat(TempParticipants).Distinct().OrderBy(x=>x).ToList();
        }
    }
}
