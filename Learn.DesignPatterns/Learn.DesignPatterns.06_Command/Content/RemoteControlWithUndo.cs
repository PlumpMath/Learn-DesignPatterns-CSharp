﻿using System.Text;

namespace Learn.DesignPatterns._06_Command.Content
{
  public class RemoteControlWithUndo
  {
    ICommand[] onCommands;
    ICommand[] offCommands;
    ICommand undoCommand;

    public RemoteControlWithUndo()
    {
      onCommands = new ICommand[7];
      offCommands = new ICommand[7];

      var noCommand = new NoCommand();

      for (int i = 0; i < 7; i++)
      {
        onCommands[i] = noCommand;
        offCommands[i] = noCommand;
      }

      undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
      onCommands[slot] = onCommand;
      offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
      onCommands[slot].Execute();
      undoCommand = onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
      offCommands[slot].Execute();
      undoCommand = offCommands[slot];
    }

    public void UndoButtonWesPushed()
    {
      undoCommand.Undo();
    }

    public override string ToString()
    {
      StringBuilder stringBuild = new StringBuilder();

      stringBuild.Append("\n----- Remote Control -----\n");

      for (int i = 0; i < onCommands.Length; i++)
      {
        stringBuild.Append("[slot " + i + "] " + onCommands[i].GetType().Name + "  " + offCommands[i].GetType().Name + "\n");
      }

      return stringBuild.ToString();
    }
  }
}
