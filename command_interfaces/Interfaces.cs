namespace PluginAPI.Assembly;

internal interface ICommand
{
  string Prefix { get; }
  string CommandName { get; }
  string CommandDescription { get; }
  string[] Parameters { set; }
  void Execute();
}
