using System;
using System.IO;
using CodeevalChallenges;

class Program
{
    static void Main(string[] args)
    {

        _93_CapitalizeWords challenge;
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                {
                    continue;

                }

                challenge = new _93_CapitalizeWords(line);
                Console.WriteLine(challenge.Capitalize());


            }

        }

    }
}

