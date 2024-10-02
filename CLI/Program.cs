using StandardCommands;

namespace CLI
{
  internal class Program
  {
	public static void Main(string[] args)
	{
	  Command _ = new();
	  _.Parameters = args;
	  _.Execute();
	}
  }
}
