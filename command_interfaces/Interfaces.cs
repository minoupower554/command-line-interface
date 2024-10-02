namespace CommandInterfaces
{
  public interface ICommand
  {
	static string? Prefix => Prefix;
	static string? CommandName { get; } = "test";
	static string? CommandDescription => CommandDescription;
	string[] Parameters { set; }
	void Execute();
  }
}
