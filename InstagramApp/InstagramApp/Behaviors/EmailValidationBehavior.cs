using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace InstagramApp.Behaviors
{
    public class EmailValidationBehavior: Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_OnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_OnTextChanged;
        }

        private void Bindable_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;

            var emailPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                       @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                       @".)+))([a-zA-Z]{2,6}|[0-9]{1,3})(\]?)$";

            var emailEntry = sender as Entry;

            if (Regex.IsMatch(email, emailPattern))
            {
                emailEntry.BackgroundColor = Color.Transparent;
            }
            else
            {
                emailEntry.BackgroundColor = Color.Red;
            }
        }
    }
}
