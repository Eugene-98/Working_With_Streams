using System;
using System.IO;
using System.Text;

namespace Working_With_Streams
{
	public static class WritingToStream
    {
        public static void ReadAndWriteIntegers(StreamReader streamReader, StreamWriter outputWriter)
        {
            int i;
            while ((i = streamReader.Read()) > -1)
            {
                outputWriter.Write(i);
            }
        }

        public static void ReadAndWriteChars(StreamReader streamReader, StreamWriter outputWriter)
        {
            int i;
            while ((i = streamReader.Read()) > -1)
            {
                outputWriter.Write(Convert.ToChar(i));
            }

            outputWriter.Flush();
        }

        public static void TransformBytesToHex(StreamReader contentReader, StreamWriter outputWriter)
        {
            while (contentReader.Peek() > -1)
            {
                outputWriter.Write("{0:X2}", contentReader.Read());
            }
        }

        public static void WriteLinesWithNumbers(StreamReader contentReader, StreamWriter outputWriter)
        {
            int i = 1;
            while (contentReader.Peek() > -1)
            {
                outputWriter.WriteLine("{0:D3} {1}", i, contentReader.ReadLine());
                i++;
            }

            outputWriter.Flush();
        }

        public static void RemoveWordsFromContentAndWrite(StreamReader contentReader, StreamReader wordsReader, StreamWriter outputWriter)
        {
            StringBuilder content = new StringBuilder();
            content.Append(contentReader.ReadToEnd());
            while (wordsReader.Peek() > -1)
            {
                content.Replace(wordsReader.ReadLine(), string.Empty);
            }

            outputWriter.Write(content);
            outputWriter.Flush();
        }
    }
}
