namespace tabuleiro
{
    internal class Tabuleiro
    {

        public int Linha { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas;

        public Tabuleiro(int linha, int colunas)
        {
            Linha = linha;
            Colunas = colunas;
            _pecas = new Peca[linha, colunas];
        }

        public Peca Peca(int linha, int colunas)
        {
            return _pecas[linha, colunas];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            _pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }


    }
}
