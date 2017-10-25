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
                    }
                }


                firstsDaGramatica.Add(entry.Key, firsts.ToArray());

                if (firsts == null) {
                    Console.WriteLine("Fudeu");
                }

            }



            return null;
        }
    }
}
