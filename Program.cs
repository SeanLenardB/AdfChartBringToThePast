using System.Text.Json.Nodes;

internal class Program
{
	private static void Main(string[] args)
	{
		Conv();

	}

	private static void Conv()
	{
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.WriteLine("Please drag & drop the .adofai file:");
		while (true)
		{
			try
			{
				string path = Console.ReadLine()!;
				if (path[0] == '"')
				{
					path = path[1..^1];
				}

				string chartText = File.ReadAllText(path);
				//protect
				chartText = chartText.Replace("\"legacyFlash\":", "\"legacyFlash\" -");
				chartText = chartText.Replace("\"legacyCamRelativeTo\":", "\"legacyCamRelativeTo\" -");
				chartText = chartText.Replace("\"legacySpriteTiles\":", "\"legacySpriteTiles\" -");

				chartText = chartText.Replace("\": false", "\": \"Disabled\"");
				chartText = chartText.Replace("\": true", "\": \"Enabled\"");

				//protect
				chartText = chartText.Replace("\"legacyFlash\" -", "\"legacyFlash\":");
				chartText = chartText.Replace("\"legacyCamRelativeTo\" -", "\"legacyCamRelativeTo\":");
				chartText = chartText.Replace("\"legacySpriteTiles\" -", "\"legacySpriteTiles\":");

				File.WriteAllText(path.Insert(path.Length - 7, "_converted"), chartText);

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("OK!");
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("You may convert more charts if necessary.\nPlease drag & drop the .adofai file:");
			}
		}
	}
}