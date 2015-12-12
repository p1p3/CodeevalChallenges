using System;
using System.IO;

namespace CodeevalChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            _20_Lowercase challenge;
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    challenge = new _20_Lowercase(line);
                    Console.WriteLine(challenge.GetLowerText());

                }
        }
    }
}
