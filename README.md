# smol command handler with dynamic dll loading

simple handler code for dynamic DLL loading with provided standard commands

### how to implement your own commands

Base Class provided by PluginAPI.Assembly.dll

**Values** | **Type** | **Explanation** | 
-|-|-
Prefix | string | defines the keyword used for the command ***(required)***
CommandName | string | used in the help command as the name ***(optional)***
CommandDescription | string | used in the help command as the description ***(optional)***
Parameters | string[] | provides the parameters defined after getting rid of the prefix ***(required)***
Execute() | void Method | the function getting ran after Parameters has been defined ***(required)***
