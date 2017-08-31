using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculatePracticeApp
{
    public class CustomCommand : Command
    {
        public Func<object, bool> CanExecuteDelegate;
        public Action<object> ExecuteDelegate;
        public Action<object> UnexecuteDelegate;

   
        public CustomCommand(Func<object, bool> canExecute, Action<object> execute) : base(execute, canExecute)
        {
            this.CanExecuteDelegate = canExecute;
            this.ExecuteDelegate = execute;
            
        }

        public CustomCommand(Action<object> execute) : base(execute)
        {
            this.CanExecuteDelegate = (par) => { return true; };
            this.ExecuteDelegate = execute;
            
        }

        public CustomCommand(Action<object> execute, Action<object> unexecute) : base(execute)
        {
            this.CanExecuteDelegate = (par) => { return true; };
            this.ExecuteDelegate = execute;
            this.UnexecuteDelegate = unexecute;
        }

        //public bool CanExecute(object parameter)
        //{
        //    return CanExecuteDelegate.Invoke(parameter);
        //}

        //public void Execute(object parameter = null)
        //{
        //    ExecuteDelegate.Invoke(parameter);
        //}
        public void Unexecute(object parameter = null)
        {
            UnexecuteDelegate.Invoke(parameter);
        }
    }
}
