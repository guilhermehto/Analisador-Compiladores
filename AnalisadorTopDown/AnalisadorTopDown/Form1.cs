using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AnalisadorTopDown {
    public partial class Form1 : Form {

        private Dictionary<string, string[]> _producoes;
        private string _gramatica;
        private int _maxProducoes = 10;
        public Form1() {
            InitializeComponent();
            _producoes = new Dictionary<string, string[]>();
            labelProducoesRestantes.Text = "Produções restantes " + _maxProducoes;
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            if (_maxProducoes == 0) {
                MessageBox.Show("Você já adicionou uma produção como esta", "Tenta novamente", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            try {
                _maxProducoes--;
                labelProducoesRestantes.Text = "Produções restantes " + _maxProducoes;
                var ladoEsquerdo = txtLadoEsquerdo.Text;
                var producoesLadoDireito = txtLadoDireito.Text;
                producoesLadoDireito = producoesLadoDireito.Replace(" ", string.Empty);
                var producoesSeparadas = producoesLadoDireito.Split('|');
                _producoes.Add(ladoEsquerdo, producoesSeparadas);
                txtLadoEsquerdo.Text = "";
                txtLadoDireito.Text = "";
                txtFieldGramatica.Text = "";
                foreach (var entry in _producoes) {
                    var producoes = "";
                    for (int i = 0; i < entry.Value.Length; i++) {
                        producoes += entry.Value[i] + (i < entry.Value.Length - 1 ? " | " : " ");
                    }
                    txtFieldGramatica.Text += entry.Key + " -> " + producoes + "\n";
                }
            } catch (Exception ex) {
                MessageBox.Show("Você já adicionou uma produção como esta", "Tenta novamente",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnGerarFirstEFollow_Click(object sender, EventArgs e) {
            Gerador.GerarFirst(_producoes);
        }
    }
}
