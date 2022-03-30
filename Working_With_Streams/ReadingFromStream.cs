using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Working_With_Streams
{
	public static class ReadingFromStream
    {
        public static string ReadAllStreamContent(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }

        public static string[] ReadLineByLine(StreamReader streamReader)
        {
            string line;
            List<string> linesList = new List<string>();
            while ((line = streamReader.ReadLine()) != null)
            {
                linesList.Add(line);
            }

            return linesList.ToArray();
        }

        public static StringBuilder ReadOnlyLettersAndNumbers(StreamReader streamReader)
        {
            StringBuilder line = new StringBuilder();
            while (streamReader.Peek() > -1)
            {
                if (!char.IsLetterOrDigit((char)streamReader.Peek()))
                {
                    return line;
                }

                line.Append((char)streamReader.Read());
            }

            return line;
        }

        public static char[][] ReadAsCharArrays(StreamReader streamReader, int arraySize)
        {
            char[] line = null;
            List<char[]> linesList = new List<char[]>();
            while (streamReader.Peek() > -1)
            {
                line = new char[arraySize];
                int i = streamReader.ReadBlock(line, 0, arraySize);
                if (i == arraySize)
                {
                    linesList.Add(line);
                }
                else
                {
                    Array.Resize(ref line, i);
                    linesList.Add(line);
                }
            }

            return linesList.ToArray();
        }
    }
}
