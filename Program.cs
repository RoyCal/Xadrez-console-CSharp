using Xadrez;

internal class Program{
    private static void Main(string[] args){
        
        try{
            PartidaDeXadrez partida = new PartidaDeXadrez();
    
            while(!partida.terminada){

                try{
                    Console.Clear();
                    Tela.imprimirPartida(partida);
        
                    System.Console.WriteLine();
                    System.Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    partida.validarPosicaoDeOrigem(origem);
        
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
        
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
        
                    System.Console.WriteLine();
                    System.Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
                    partida.validarPosicaoDeDestino(origem, destino);
        
                    partida.realizaJogada(origem, destino);
                } catch(TabuleiroException e){
                    System.Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Tela.imprimirPartida(partida);
        } catch(TabuleiroException e){
            System.Console.WriteLine(e.Message);
        }
    }
}