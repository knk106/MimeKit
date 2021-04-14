using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MimeKit;

namespace ConsoleApp1
{
    class Program
    {
		static MimeParser Parser = null;
		static void Main(string[] args)
        {
			string path = @"E:\Docs\Outlook OST\test_eml\mbox\Selected EML Files\Selected EML Files.mbox";
			using (FileStream fs = new FileStream (path, FileMode.Open, FileAccess.Read)) {
				Parser = new MimeParser (fs, MimeFormat.Mbox);

				int i = 0;
				long lastPosition = 0;
				while (!Parser.IsEndOfStream) {
					var mimeMessage = Parser.ParseMessage (true);
					i++;
					Console.WriteLine (i);
				}
			}
		}
    }
}
