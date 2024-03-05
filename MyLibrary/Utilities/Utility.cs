using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Utilities
{
    class Utility
    {
        public static void Clear(ListBox listBox, TextBox numTextBox, TextBox desTextBox, TextBox uOHTextBox, TextBox minTextBox, TextBox maxTextBox)
        {
            listBox.Items.Clear();
            numTextBox.Text = "";
            desTextBox.Text = "";
            uOHTextBox.Text = "";
            minTextBox.Text = "";
            maxTextBox.Text = "";
        }
    }
}
