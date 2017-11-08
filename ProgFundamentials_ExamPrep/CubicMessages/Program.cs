using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            List<string> messagesOutput = new List<string>();
            while (message != "Over!")
            {
                int m = int.Parse(Console.ReadLine());
                Regex regex = new Regex("([\\d]+){1}([a-zA-Z]+){1}([^a-zA-Z\\s]+){1}");
                string[] split = Regex.Split(message, "([\\d]+){1}([a-zA-Z]+){1}");
                if(CheckMessageAutetication(message, split, m))
                {
                    messagesOutput.Add(GetMessage(split));
                }
                message = Console.ReadLine();
            }
            foreach(string msg in messagesOutput)
            {
                    Console.WriteLine(string.Join(Environment.NewLine, msg));
            }
        }

        private static string GetMessage(string[] split)
        {
            string encryptedMessage = split[2];
            string beginning = split[1];
            string end = split[3];
            StringBuilder message = new StringBuilder();
            string output = null;
            for (int i =0; i < beginning.Length; i++)
            {
                if(int.Parse(beginning[i].ToString())<0||int.Parse(beginning[i].ToString())> encryptedMessage.Length-1)
                {
                    message.Append(" ");
                }
                else
                {
                    message.Append(encryptedMessage[int.Parse(beginning[i].ToString())]);
                }
            }
            for (int j = 0; j < end.Length; j++)
            {
                if (char.IsDigit(end[j]))
                {
                    if (int.Parse(end[j].ToString()) < 0 || int.Parse(end[j].ToString()) > encryptedMessage.Length-1)
                    {
                        message.Append(" ");
                    }
                    else
                    {
                        message.Append(encryptedMessage[int.Parse(end[j].ToString())]);
                    }
                }
            }
                output= $"{encryptedMessage} == {message.ToString()}";  
            return output;
        }

        private static bool CheckMessageAutetication(string message, string[] split,int messageLenght)
        {
            if(split.Length==4&&split[2].Length== messageLenght)
            {
                StringBuilder collectArrayElements = new StringBuilder();
                foreach (string word in split)
                {
                        collectArrayElements.Append(word);
                }
                if (split[0] != "")
                {
                    return false;
                }
                if((split[3].Any(a=> char.IsLetter(a))))
                {
                    return false;
                }
                if (collectArrayElements.Length == message.Length)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
