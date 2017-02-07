﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeituraiBibliaDesafio
{
    public class ManipuladorArquivos
    {
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "Bíblia Sagrada.txt";

        public static void LerBiblia()
        {
            if (File.Exists(EnderecoArquivo))
            {
                using (StreamReader leitor = File.OpenText(EnderecoArquivo))
                {
                    while (leitor.Peek() >=0)
                    {
                        Console.WriteLine(leitor.ReadLine());
                        int i = 0;
                        if (i == 10)
                        {
                            break;
                        }
                        i++;
                    }
                }
            }
        }
    }
}
