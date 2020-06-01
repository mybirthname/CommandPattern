using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class ModifyPrice
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public ModifyPrice()
        {

        }

        public void Invoike(ICommand command)
        {
            if (!_commands.Contains(command))
                _commands.Add(command);

            command.ExecuteAction();
        }

        public void Undo(ICommand command)
        {
            if (!_commands.Contains(command))
                _commands.Add(command);

            command.UndoAction();
        }
    }
}
