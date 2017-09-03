using System;
public class Substring_broken
{
    public static void Main()
	{
        // 0...1.2.3.45678.9 = 10 length
		string text = Console.ReadLine();
        //3
		int jump = int.Parse(Console.ReadLine());
        int saveJump = jump;

		const char Search = 'p';
		bool hasMatch = false;
        int endIndex = 0;

		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == Search)
			{
				hasMatch = true;

                if (text.Length - i <= jump)
	            {
                    endIndex = jump;
	            }
                else
	            {
                    endIndex = jump + 1;
	            }

                string matchedString = text.Substring(i,endIndex);

				Console.WriteLine(matchedString);

				i += jump;
			}
		}

		if (!hasMatch)
		{
			Console.WriteLine("no");
		}
	}
}
