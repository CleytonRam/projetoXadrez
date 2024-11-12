



namespace tabuleiro {
    class Peca {
        public Position position {  get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab {  get; protected set; }

        public Peca(Position position, Tabuleiro tab, Cor cor) {
            this.position = position;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
}
