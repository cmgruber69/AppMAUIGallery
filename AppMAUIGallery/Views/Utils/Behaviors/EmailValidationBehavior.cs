﻿namespace AppMAUIGallery.Views.Utils.Behaviors
{
    public class EmailValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = ((Entry)sender);
            if (e.NewTextValue.Contains("@") && e.NewTextValue.Contains(".com"))
            {
                entry.TextColor = Colors.Green;
            }
            else
            {
                entry.TextColor = Colors.Red;
                entry.FontAttributes = FontAttributes.Bold;
            }
        }
    }
}
