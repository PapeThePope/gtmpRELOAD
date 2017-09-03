/*
ReloadScript by Tobias Pape
*/
using GrandTheftMultiplayer.Server.API;

public class Reloader : Script
{
    public Reloader()
    {
    }


    [Command("reload", GreedyArg = true)]
    public void reloadCommand(Client sender, string name)
    {
        API.stopResource(name);
        API.startResource(name);
    }
    [Command("stopres", GreedyArg = true)]
    public void stopCommand(Client sender, string name)
    {
        API.stopResource(name);
    }
    [Command("startres", GreedyArg = true)]
    public void startCommand(Client sender, string name)
    {
        API.startResource(name);
    }
}
