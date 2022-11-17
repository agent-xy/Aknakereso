using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Aknakereso.Classes
{
    class Mezo
    {
        public Button Texture;
        public int Value;
        public bool Felfedve;

        public Mezo(int v, int size)
        {
            Value = v;
            Felfedve = false;
            Texture = new Button()
            {
                Width = size,
                Height = size,
                Content = "",
                
            };
            Texture.Click += Texture_Click;
        }

        private void Texture_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!Back_End.First_Click)
            {
                Back_End.First_Click = true;
                Click_Show();

                Back_End._First_Click_Started();
            } else
            {
                Click_Show();
            }
            
        }

        public void Click_Show()
        {
            Felfedve = true;
            if (Value == 0)
            {
                Texture.Content = "Null";
            }

            if (Value > 0 && Value < 9)
            {
                Texture.Content = Value;
            }

            if (Value == -1)
            {
                Texture.Content = "Buum";
            }
        }
    }
}
