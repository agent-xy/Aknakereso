using System;
using System.Collections.Generic;
using System.Text;

namespace Aknakereso.Classes
{
    class Back_End
    {
        public static Map Main_Map;
        public static bool First_Click;
        public static bool Pointer_Bube;

        private static int Aknak_Szama = 12;
        private static int Map_Merete = 12;
        private static int Kocka_Meret = 50;
        
        public static void Back_End_Main()
        {
            First_Click = false;
            Pointer_Bube = false;

            _Load_Config();
        }

        private static void _Load_Config()
        {
            MainWindow._MW_V._WP_Content.Children.Clear();
            Main_Map = new Map(Map_Merete, Aknak_Szama, Kocka_Meret);
            _Show_Map_Matrix();
        }

        private static void _Show_Map_Matrix()
        {

            MainWindow._MW_V.Width = Map_Merete * (Kocka_Meret + 2);
            MainWindow._MW_V.Height = (Map_Merete * (Kocka_Meret + 5)) + 60;
            MainWindow._MW_V._WP_Content.Width = Map_Merete * Kocka_Meret;
            MainWindow._MW_V._WP_Content.Height = Map_Merete * Kocka_Meret;

            for (int i = 0; i < Main_Map.Map_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Main_Map.Map_Matrix.GetLength(1); j++)
                {
                    MainWindow._MW_V._WP_Content.Children.Add(Main_Map.Map_Matrix[i, j].Texture);
                }
            }
        }

        public static void _First_Click_Started(int o, int p)
        {
            Main_Map.Akna_Generalas(o, p);
        }
    }
}
