namespace tabuleiro
{
    internal class Tabuleiro
    {

        public int Linha { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int colunas)
        {
            Linha = linha;
            Colunas = colunas;
            pecas = new Peca[Linha,Colunas];
        }

    }
}
