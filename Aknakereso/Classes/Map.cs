using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Media;

namespace Aknakereso.Classes
{
    class Map
    {
        public Mezo[,] Map_Matrix;
        public int Akna_db;
        
        public Map(int w, int akna_db, int kocka_meret)
        {
            Map_Matrix = new Mezo[w, w];
            Akna_db = akna_db;
            Create_Matrix(kocka_meret);
        }

        private void Create_Matrix(int size)
        {
            for (int i = 0; i < Map_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Map_Matrix.GetLength(1); j++)
                {
                    Map_Matrix[i, j] = new Mezo(0, size, i, j);
                }
            }
        }

        public void Akna_Generalas(int o, int p)
        {
            Console.WriteLine("Akna gen started");
            for (int i = 0; i < Akna_db; i++)
            {
                bool ok = false;
                do
                {
                    Random rnd = new Random();
                    int m_i = rnd.Next(Map_Matrix.GetLength(0));
                    int m_j = rnd.Next(Map_Matrix.GetLength(1));

                    if (Map_Matrix[m_i, m_j].Value >= 0 && !Map_Matrix[m_i, m_j].Felfedve)
                    {
                        Map_Matrix[m_i, m_j].Value = -99;
                        ok = true;

                        Mezo_Feltoltes(m_i, m_j);
                    }
                } while (!ok);
            }
        }

        public void Mezo_Feltoltes(int i, int j)
        {
            for (int q = i - 1; q < 2 + i; q++)
            {
                for (int k = j - 1; k < 2 + j; k++)
                {
                    if (q >= 0 && q <= Map_Matrix.GetLength(0) - 1 && k >= 0 && k <= Map_Matrix.GetLength(1) - 1 && Map_Matrix[q, k].Value >= 0)
                    {
                        Map_Matrix[q, k].Value += 1;
                    }
                }
            }
        }

        public void Ures_Kocka_Felfed(int i, int j)
        {
            for (int q = i - 1; q < 2 + i; q++)
            {
                for (int k = j - 1; k < 2 + j; k++)
                {
                    if (q >= 0 && q <= Map_Matrix.GetLength(0) - 1 && k >= 0 && k <= Map_Matrix.GetLength(1) - 1)
                    {
                        if (Map_Matrix[q, k].Value == 0 && !Map_Matrix[q, k].Felfedve)
                        {
                            Map_Matrix[q, k].Click_Show();
                        }
                    }
                }
            }
        }

        public void Show_All_Bomb()
        {
            for (int i = 0; i < Map_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Map_Matrix.GetLength(1); j++)
                {
                    Map_Matrix[i, j].Click_Show();
                }
            }
        }
    }
}
