using System;
using System.Reflection.Metadata.Ecma335;
using CommandInterfaces;

namespace StandardCommands
{
  public class Command : ICommand
  {
	private static readonly string _Prefix = "test";
	private static readonly string _Name = "test command";
	private static readonly string _Desc = "test command";
	private string[] _Parameters = []; // shut up chatgpt this works and you cant change my mind

	public static string Prefix => _Prefix;
	public string CommandName { get { return _Name; } }
	public string CommandDescription { get { return _Desc; } }
	public string[] Parameters { set { _Parameters = value; } }

	public void Execute()
	{
	  Console.WriteLine(string.Join(", ", _Parameters));
	}
  }
}
