using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpInterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = GetFileLines();
            int i = 0;
            foreach(var line in lines)
            {
                /*if(i >= 3)
                {
                    break;
                }*/
                i++;

                Console.WriteLine(line);
            }
        }

        private static IEnumerable<string> GetFileLines()
        {
            using (var stream = new FileStream(@"d\tmp\quijote.txt", FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line = null;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            yield return line;
                        }
                    } while (line != null);
                    yield break;
                }
            }
        }
    }
}
