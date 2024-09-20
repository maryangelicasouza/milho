namespace milho;

public class Gerenciador
{

    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;

    public Gerenciador (Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5 )
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5); 
    }

    public void ProximaPergunta()
    {
        var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count -1);
        while(ListaQuestoesRespondidas.Contains(numRandomico))
        numRandomico = Random.Shared.Next(0,ListaQuestoes.Count -1);
        ListaQuestoesRespondidas.Add(numRandomico);
        questaoCorrente = ListaQuestoes[numRandomico];
        questaoCorrente.Desenhar();
    }

    public async void VerificarCorreto(int resposta)
    {
        if (questaoCorrente!.VerifiicarResposta(resposta))
        {
            await Task.Delay(1500);
            ProximaPergunta();
        }
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        var Q1 = new Questao();
        Q1.pergunta = "Quem escreveu Dom Casmurro ?";
        Q1.resposta1 = " Manuel Bandeira";
        Q1.resposta2 = "Jorge Amado";
        Q1.resposta3 = " Machado de Assis";
        Q1.resposta4 = "Clarice Lispector";
        Q1.resposta5 = "Guimarães Rosa";
        Q1.respostacerta = 3;
        Q1.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);

        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
    Q2.pergunta = "Quem pintou a Mona Lisa?";
    Q2.resposta1 = "Michelangelo";
    Q2.resposta2 = "Pablo Picasso";
    Q2.resposta3 = "Leonardo da Vinci";
    Q2.resposta4 = "Vincent van Gogh";
     Q2.resposta5 = "Claude Monet";
     Q2.respostacerta = 3;
;
        Q2.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);

        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.pergunta = "";
        Q3.resposta1 = "";
        Q3.resposta2 = "";
        Q3.resposta3 = "";
        Q3.resposta4 = "";
        Q3.resposta5 = "";
        Q3.respostacerta = 5;
        Q3.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);

        ListaQuestoes.Add(Q3);

    }

}
