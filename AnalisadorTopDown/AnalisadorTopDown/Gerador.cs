﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AnalisadorTopDown {
    public static class Gerador {
        public static Dictionary<string, string[]> GerarFirst(Dictionary<string, string[]> gramatica) {
            var firstsDaGramatica = new Dictionary<string, string[]>();
            foreach (var entry in gramatica.Reverse()) {
                var regexNaoTerminais = @"[a-z0-9E]";
                List<string> firsts = new List<string>();
                foreach (var producao in entry.Value) {
                    if (Regex.Match(producao, regexNaoTerminais).Success) {
                        firsts.Add(producao[0].ToString());
                        //acha todos os firts do NT
                    } else {// Não achou um T naquela producao (BASICAMENTE FAZ O METODO DE NOVO
                        
                        //Procurar em outras "entrys" pelo first do NT
                        foreach (var newEntry in gramatica.Reverse()) {
                            if (newEntry.Key[0] == producao[0]) { // Se a chave da nova entrada é o NT em questão
                                foreach (var newProducao in newEntry.Value) { // Cada produção da nova entrada
                                    if (Regex.Match(newProducao, regexNaoTerminais).Success)
                                        firsts.Add(newProducao[0].ToString());
                                }

                            }
                        }

                        
                        /*
                        //NAO ME PERGUNTE
                        Dictionary<string, string[]> dicionarioTemp = new Dictionary<string, string[]>(gramatica);
                        dicionarioTemp.Remove(entry.Key);
                        //MessageBox.Show(producao[0].ToString() + " " + vetorTemp[0]);
                        firsts.Add(GerarFirst(dicionarioTemp)[producao[0].ToString()][0]);
                        */
                    }



                    if (firsts == null) {
                        Console.WriteLine("Fudeu");
                    }

                }
                firstsDaGramatica.Add(entry.Key, firsts.ToArray());



            }
            return firstsDaGramatica;
        }
    }
}
