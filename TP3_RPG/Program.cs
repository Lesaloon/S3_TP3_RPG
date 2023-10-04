namespace TP3_RPG
{
	class Program
	{
		static void Main(string[] args) {
			string name = "unknown";
			if (args.Length > 0) {
				name = args[0];
			}
			Console.WriteLine("Hi Mom ! It's me " + name);
		}
	}
} 

