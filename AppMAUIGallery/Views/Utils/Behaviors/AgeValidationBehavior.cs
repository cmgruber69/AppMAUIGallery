﻿namespace AppMAUIGallery.Views.Utils.Behaviors
{
    public class AgeValidationBehavior : Behavior<Entry>
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
            var entry = (Entry)sender;
            int age;
            if (int.TryParse(e.NewTextValue, out age))
            {
                if (age >= 18)
                {
                    entry.TextColor = Colors.Green;
                }
                else
                {
                    entry.TextColor = Colors.Red;
                    entry.FontAttributes = FontAttributes.Bold;
                }
            }
            else
            {
                entry.TextColor = Colors.Orange;
            }
        }
    }
}
