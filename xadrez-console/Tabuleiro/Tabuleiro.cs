using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            this.linhas = linha;
            this.colunas = coluna;
            pecas = new Peca[linha, coluna];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca (Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
                throw new TabuleiroException("Já existe peça nesta posição. ");


            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
                return null;


            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;

            return aux;
        }

        public bool PosicaoValida (Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            return false;

          return true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
                throw new TabuleiroException("Posicao Inválida. ");
        }
    }
}
