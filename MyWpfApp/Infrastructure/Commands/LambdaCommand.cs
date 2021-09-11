using MyWpfApp.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpfApp.Infrastructure.Commands
{
    class LambdaCommand : CommandBase
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public LambdaCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _canExecute = canExecute;
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }

        public override bool CanExecute(object parameter)
        {
           return _canExecute?.Invoke(parameter) ?? true;
        }

        public override void Execute(object parameter) => _execute(parameter);        
    }
}
