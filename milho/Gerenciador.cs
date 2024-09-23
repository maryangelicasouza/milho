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
            AdicionaPontuacao(NivelAtual);
            NivelAtual ++;
            ProximaPergunta();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Você errou", "Desistir é para os fracos o ideal é nem tentar,tente mais uma vez", "tentar novante!");
            Inicializar();
        }

        void AdicionaPontuacao(int n)
        {
            if (n ==1)
               Pontuacao=1000;
            else if (n ==2)
               Pontuacao=2000;
            else if (n ==3)
               Pontuacao=5000;
            else if (n ==4)
              Pontuacao=10000;
            else if ( n ==5)
              Pontuacao=20000;
            else if (n == 6)
              Pontuacao=50000;
            else if (n == 7)
              Pontuacao=10000;
            else if ( n ==8)
              Pontuacao=20000;
           else if (n ==9)
              Pontuacao=500000;
           else if (n ==10)
               Pontuacao=100000;
        }

    }

    public int Pontuacao {get;private set;}
    int NivelAtual = 0;

    void Inicializar()
    {
        Pontuacao = 0;
        NivelAtual =0;
        ProximaPergunta();
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        var Q1 = new Questao();
        Q1.Nivel=4;
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
         Q1.Nivel=3;
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
         Q1.Nivel=3;
Q3.pergunta = "Qual é o maior planeta do sistema solar?";
Q3.resposta1 = "Terra";
Q3.resposta2 = "Júpiter";
Q3.resposta3 = "Saturno";
Q3.resposta4 = "Marte";
Q3.resposta5 = "Vênus";
Q3.respostacerta = 2;

Q3.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q3);

var Q4 = new Questao();
 Q1.Nivel=2;
Q4.pergunta = "Qual elemento químico tem o símbolo 'O'?";
Q4.resposta1 = "Ouro";
Q4.resposta2 = "Oxigênio";
Q4.resposta3 = "Ósmio";
Q4.resposta4 = "Osmônio";
Q4.resposta5 = "Opala";
Q4.respostacerta = 2;

Q4.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q4);

var Q5 = new Questao();
 Q1.Nivel=1;
Q5.pergunta = "Qual é o nome do planeta mais próximo do Sol?";
Q5.resposta1 = "Vênus";
Q5.resposta2 = "Marte";
Q5.resposta3 = "Mercúrio";
Q5.resposta4 = "Terra";
Q5.resposta5 = "Júpiter";
Q5.respostacerta = 3;

Q5.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q5);

var Q6 = new Questao();
 Q1.Nivel=1;
Q6.pergunta = "Qual é a língua mais falada do mundo?";
Q6.resposta1 = "Inglês";
Q6.resposta2 = "Mandarim";
Q6.resposta3 = "Espanhol";
Q6.resposta4 = "Hindi";
Q6.resposta5 = "Árabe";
Q6.respostacerta = 2;

Q6.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q6);

var Q7 = new Questao();
 Q1.Nivel=1;
Q7.pergunta = "Qual é o país conhecido como 'Terra do Sol Nascente'?";
Q7.resposta1 = "China";
Q7.resposta2 = "Japão";
Q7.resposta3 = "Coreia do Sul";
Q7.resposta4 = "Tailândia";
Q7.resposta5 = "Filipinas";
Q7.respostacerta = 2;
Q7.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q7);

var Q8 = new Questao();
 Q1.Nivel=1;
Q8.pergunta = "Qual é o sabor típico do sorvete de flocos?";
Q8.resposta1 = "Chocolate";
Q8.resposta2 = "Baunilha";
Q8.resposta3 = "Morango";
Q8.resposta4 = "Flocos de chocolate";
Q8.resposta5 = "Coco";
Q8.respostacerta = 4;

Q8.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q8);

var Q9 = new Questao();
 Q1.Nivel=3;
Q9.pergunta = "Qual é o país conhecido pela torre inclinada?";
Q9.resposta1 = "França";
Q9.resposta2 = "Espanha";
Q9.resposta3 = "Itália";
Q9.resposta4 = "Alemanha";
Q9.resposta5 = "Brasil";
Q9.respostacerta = 3;

Q9.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q9);

var Q10 = new Questao();
Q10.pergunta = "Qual é o famoso personagem de desenho que tem um cachorro chamado Scooby?";
Q10.resposta1 = "Tom";
Q10.resposta2 = "Jerry";
Q10.resposta3 = "Fred";
Q10.resposta4 = "Shaggy";
Q10.resposta5 = "Scooby-Doo";
Q10.respostacerta = 5;

Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q10);

var Q11 = new Questao();
Q11.pergunta = "Qual é o nome do super-herói que veste uma capa e voa pelo céu?";
Q11.resposta1 = "Batman";
Q11.resposta2 = "Superman";
Q11.resposta3 = "Spider-Man";
Q11.resposta4 = "Homem de Ferro";
Q11.resposta5 = "Thor";
Q11.respostacerta = 2;

Q11.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q11);

var Q12 = new Questao();
Q12.pergunta = "Qual é a capital da Itália?";
Q12.resposta1 = "Milão";
Q12.resposta2 = "Roma";
Q12.resposta3 = "Nápoles";
Q12.resposta4 = "Florença";
Q12.resposta5 = "Veneza";
Q12.respostacerta = 2;

Q12.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaQuestoes.Add(Q12);



    }

}
