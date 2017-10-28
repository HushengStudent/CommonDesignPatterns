using UnityEngine;
using System.Collections;

public class Invoker 
{
    private AbsCommand command;

    public void SendCommand(AbsCommand command)
    {
        this.command = command;
    }

    public void ExecuteCommand()
    {
        command.Execute();
    }
}
