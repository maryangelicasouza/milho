namespace milho
{
    public class Gerenciador
    {
List <Questao> ListaQuestoes = new Lista <Questoes>();
List <int> ListaQuestoesRespondidas = new Lista <int>();
Questao QuestaoAtual;
public Gerenciador(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
{
    CriarQuestoes (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5);
}
void  CriarQuestoes (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
{
    var Q1 = new Questao();
    

}
public void ProximaQuestao()
{
    var numRandomico = Random.Shared.Next (0,ListaQuestoesRespondidas.Count);
    while (ListaQuestoesRespondidas.Contains (numRandomico) )
    numRandomico = Random.Shared.Next (0,ListaQuestoesRespondidas.Count -1);

    ListaQuestoesRespondidas.Add (numRandomico);
    QuestaoAtual = ListaQuestoes[numRandomico];
    QuestaoAtual.Desenhar();
}
public async void VerfiicaCorreto (int RespostaSelecionada)
{
    if (QuestaoAtual.VerificaResposta(RespostaSelecionada))
    {
        await Task.Delay (1000);
        ProximaQuestao();
    }
}
    }
}