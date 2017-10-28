using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
                    } else {// Não achou um T naquela producao
                        //Procurar em outras "entrys" pelo first do NT
                        foreach (var newEntry in gramatica.Reverse()) {
                            if (newEntry.Key[0] == producao[0]) { // Se a chave da nova entrada é o NT em questão
                                foreach (var newProducao in newEntry.Value) { // Cada produção da nova entrada
                                    if (Regex.Match(newProducao, regexNaoTerminais).Success)
                                        firsts.Add(newProducao[0].ToString());
                                }

                            }
                        }
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
