namespace milho
{
    public class Gerenciador
    {
List <Questao> ListaQuestoes = new Lista <Questoes>();
List <int> ListaQuestoesRespondidas = new Lista <int>();
Questao questaoCorrente;

public Gerenciador(Label labelpergunta, Button  buttonresposta1, Button  buttonresposta2, Button  buttonresposta3, Button  buttonresposta4, Button  buttonresposta5)
{
    CriarQuestoes (labelpergunta, buttonresposta1,  buttonresposta2,  buttonresposta3,  buttonresposta4,   buttonresposta5);
}

void  CriarQuestoes (Label labelpergunta, Button buttonresposta1, Button buttonresposta2, Button buttonresposta3, Button buttonresposta4, Button buttonresposta5)
{
    var Q1 = new Questao();
    Q1.pergunta = "";
    Q1.resposta1 = "";
    Q1.resposta2 = "";
    Q1.resposta3 = "";
    Q1.resposta4 = "";
    Q1.resposta5 = "";
    Q1.respostacerta = "";
    Q1.ConfiguraEstruturaDesenho(labelpergunta, ButtonResposta1, buttonresposta2, buttonresposta3, ButtonResposta4, ButtonResposta5);

    ListaQuestoes.Add(Q1);
    var Q2 =new Questao();
}
      
public void ProximaQuestao()
{
    var numRandomico = Random.Shared.Next (0,ListaQuestoesRespondidas.Count);
    while (ListaQuestoesRespondidas.Contains (numRandomico) )
    numRandomico = Random.Shared.Next (0,ListaQuestoesRespondidas.Count );

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

