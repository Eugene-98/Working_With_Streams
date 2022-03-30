using System;
using System.IO;

namespace Working_With_Streams
{
	public static class ReadingFromString
    {
        public static string ReadAllStreamContent(StringReader stringReader)
        {
            string content = stringReader.ReadToEnd();
            return content;
        }

        public static string ReadCurrentLine(StringReader stringReader)
        {
            string content = stringReader.ReadLine();
            return content;
        }

        public static bool ReadNextCharacter(StringReader stringReader, out char currentChar)
        {
            int i = stringReader.Read();
            if (i == -1)
            {
                currentChar = ' ';
                return false;
            }
            else
            {
                currentChar = Convert.ToChar(i);
                return true;
            }
        }

        public static bool PeekNextCharacter(StringReader stringReader, out char currentChar)
        {
            if (stringReader.Peek() == -1)
            {
                currentChar = ' ';
                return false;
            }
            else
            {
                currentChar = (char)stringReader.Peek();
                return true;
            }
        }

        public static char[] ReadCharactersToBuffer(StringReader stringReader, int count)
        {
            char[] b = new char[count];
            stringReader.Read(b, 0, count);
            return b;
        }
    }
}
