namespace PluginAPI.Assembly;

public abstract class Command : ICommand
{
  public abstract string Prefix { get; }
  public virtual string CommandName { get; } = "No Name Provided";
  public virtual string CommandDescription { get; } = "No Description Provided";
  public abstract string[] Parameters { set; }
  public abstract void Execute();
  public static bool operator ==(Command left, string right)
  {
    if (left is null) {
      return right is null;
    }
    return left.Prefix == right;
  }
  public static bool operator !=(Command left, string right)
  {
    return !(left == right);
  }
  public override bool Equals(object? obj)
  {
    if (obj is null) { return false; }
    if (obj is Command other) {
      return Prefix == other.Prefix;
    }
    return false;
  }
  public override int GetHashCode()
  {
    return Prefix.GetHashCode();
  }
}