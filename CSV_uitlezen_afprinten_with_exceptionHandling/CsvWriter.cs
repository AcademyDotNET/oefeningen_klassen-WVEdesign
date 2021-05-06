using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSV_uitlezen_afprinten_with_exceptionHandling
{
    class CsvWriter
    {
        public static void writeCsvNoStreamWriter()
        {
            string filepath = @"E:\SkyDriveOneNote\_Cursus_Csharp_VDAB\GITHUB_REPOS\CSV\voorbeeld.csv";
            StringBuilder output = new StringBuilder();
            output.AppendLine("1,2,3");
            output.AppendLine("4,5,6");

            File.WriteAllText(filepath, output.ToString());
            File.AppendAllText(filepath, output.ToString());
        }
        public static void writeCsvStreamWriter()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"E:\SkyDriveOneNote\_Cursus_Csharp_VDAB\GITHUB_REPOS\CSV\voorbeeld.csv"))
            {
                streamWriter.WriteLine("1,2,3");
                streamWriter.WriteLine("4,5,6");
            }
        }
    }
}
