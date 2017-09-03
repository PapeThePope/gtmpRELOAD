/*
ReloadScript by Tobias Pape
*/
using System.Text;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;

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