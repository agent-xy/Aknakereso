using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace Aknakereso.Classes
{
    class Mezo
    {
        public Button Texture;
        public int Value;
        public bool Felfedve;
        public int[] Pos;

        public Mezo(int v, int size, int i, int j)
        {
            Value = v;
            Felfedve = false;
            Pos = new int[2];
            Pos[0] = i;
            Pos[1] = j;

            Texture = new Button()
            {
                Width = size,
                Height = size,
                Content = "",
                Background = default,
            };
            Texture.Click += Texture_Click;
        }

        private void Texture_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!Back_End.First_Click)
            {
                Back_End.First_Click = true;
                Felfedve = true;

                Back_End._First_Click_Started(Pos[0], Pos[1]);
                Felfedve = false;
                Click_Show();
            } else
            {
                Click_Show();
            }
        }

        public void Click_Show()
        {
            if (!Felfedve)
            {
                if (!Back_End.Pointer_Bube)
                {
                    Felfedve = true;
                    if (Value == 0)
                    {
                        Texture.Background = Brushes.Purple;
                        Back_End.Main_Map.Ures_Kocka_Felfed(Pos[0], Pos[1]);
                    }

                    if (Value > 0 && Value < 9)
                    {
                        Texture.Content = Value;
                        Texture.Background = Brushes.Aqua;
                    }

                    if (Value < 0)
                    {
                        Texture.Background = Brushes.Red;
                        Back_End.Main_Map.Show_All_Bomb();
                    }
                } else
                {
                    if (Texture.Background == Brushes.Green)
                    {
                        Texture.Background = default;
                    } else
                    {
                        Texture.Background = Brushes.Green;
                    }
                }
                
            }
        }
    }
}
