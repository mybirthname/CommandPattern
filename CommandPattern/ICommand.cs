using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface ICommand
    {
        Guid ID { get; }
        void ExecuteAction();
        void UndoAction();
    }
    
}
