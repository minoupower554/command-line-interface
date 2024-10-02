using System;
using PluginAPI.Assembly;

namespace StandardCommands
{
  public class TestCommand : Command
  {
	private readonly string _Prefix = "test";
	private static readonly string _Name = "test command";
	private static readonly string _Desc = "test command";
	private string[] _Parameters = Array.Empty<string>();

	public override string Prefix => _Prefix;
	public override string CommandName => _Name;
	public override string CommandDescription => _Desc;
	public override string[] Parameters { set => _Parameters = value; }

    public override void Execute()
	{
	  Console.WriteLine(string.Join(", ", _Parameters));
	}
  }
}
