// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

namespace MiniBug
{
    public class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem(int value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
