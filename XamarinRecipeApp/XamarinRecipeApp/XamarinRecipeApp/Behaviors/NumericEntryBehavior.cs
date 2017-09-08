using System;
using Xamarin.Forms;

namespace XamarinRecipeApp.Behaviors
{
    /// <summary>
    /// Entry Behavior for accepting only numberic text
    /// </summary>
    public class NumericEntryBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += TextChangedHandler;
        }

        /// <summary>
        /// called when xamarin forms removes the behavior from control
        /// </summary>
        /// <param name="bindable"></param>
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= TextChangedHandler;
        }

        private void TextChangedHandler(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
                return;
            double d;
            if(!double.TryParse(e.NewTextValue, out d))
            {
                ((Entry)sender).Text = e.OldTextValue; 
            }
        }
    }
}
