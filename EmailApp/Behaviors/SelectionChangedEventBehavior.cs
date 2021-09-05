using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailApp.Behaviors
{
    public class SelectionChangedEventBehavior : BehaviorBase<ListView>
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(SelectionChangedEventBehavior), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(BindableObject bindable)
        {
            base.OnAttachedTo(bindable);

            AssociatedObject.ItemSelected += AssociatedObject_ItemSelected;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);

            AssociatedObject.ItemSelected -= AssociatedObject_ItemSelected;
        }

        private void AssociatedObject_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Command != null)
            {
                Command.Execute(e.SelectedItem);
            }
        }
    }
}
