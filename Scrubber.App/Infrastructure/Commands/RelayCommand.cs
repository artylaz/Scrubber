using Scrubber.App.Infrastructure.Commands.Base;
using System;

namespace Scrubber.App.Infrastructure.Commands
{
    class RelayCommand : Command
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;
        public RelayCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            execute = Execute;
            canExecute = CanExecute;
        }

        public override bool CanExecute(object parameter) => canExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => execute(parameter);
    }
}
