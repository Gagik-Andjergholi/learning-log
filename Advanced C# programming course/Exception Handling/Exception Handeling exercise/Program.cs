List<int> list = new List<int>(3);
string input;
do
{    
	input = Console.ReadLine();
	switch (input[0])
	{
		case '1':
			list = new List<int>(3);
			break;
		case '2':
			list = null;
			break;
		case '3':
			try
			{
				list.Add(int.Parse(input.Substring(2)));
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("nulle");
			}
			break;
		case '4':
			try
			{
				Console.WriteLine(list[int.Parse(input.Substring(2))]);
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("oute");
			}
			catch(IndexOutOfRangeException)
			{
				Console.WriteLine("oute");
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("nulle");
			}
			break;
		case '5':
			int[] parts = input.Split(' ').Select(int.Parse).ToArray();
			try
			{
				Console.WriteLine(parts[1] / parts[2]);
			}
			catch (Exception ex)
			{
				Console.WriteLine("sefre");
			}
			break;
		case '6':
			break;
	}
} while (!input.Equals("6"));