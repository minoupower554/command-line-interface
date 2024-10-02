using System.Reflection;
using PluginAPI.Assembly;
using System.Data;
using System.IO;

namespace CLI
{
  internal class Program
  {
	public static void Main(string[] args)
	{
	  List<Type> CommandTypes = new List<Type>();
	  foreach (string Dll in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")) {
		Assembly assembly = Assembly.LoadFrom(Dll);
		CommandTypes.AddRange(GetCommandTypes(assembly));
      }
	  ProcessCommand(args, CommandTypes);
	}
	private static List<Type> GetCommandTypes(Assembly assembly)
	{
	  return assembly.GetTypes()
		.Where(type => type.IsClass && !type.IsAbstract &&
		typeof(Command).IsAssignableFrom(type))
		.ToList();
	}
	private static void ProcessCommand(string[] args, List<Type> Commands)
	{
	  if (args.Length == 0) {
		Console.WriteLine("please provide an Argument.");
		return;
	  }
	  foreach (Type command in Commands) {
		if (command is not null) {
		  object? Instance = Activator.CreateInstance(command);

		  if (Instance is Command CommandInstance) {
			List<string> ArgsList = args.ToList();
			ArgsList.RemoveAt(0);
			CommandInstance.Parameters = ArgsList.ToArray();
			CommandInstance.Execute();
		  }
		}
	  }
	}
  }
}
