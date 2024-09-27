namespace milho;

public class Gerenciador
{

  List<Questao> ListaTodasQuestoes = new List<Questao>();
  List<Questao> ListaTodasQuestoesRespondidas = new List<Questao>();
  Questao questaoCorrente;
  Label labelPontuacao;
  Label labelNivel;





  public Gerenciador(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5, Label labelPontuacao, Label labelNivel)
  {
    CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    this.labelPontuacao = labelPontuacao;
    this.labelNivel = labelNivel;
  }


  public void ProximaPergunta()
  {
    varListaQuestoes = ListaTodasQuestoes.Where( d.NIvelresposta == NivelAtual).ToList();
    var numRandomico = Random.Shared.Next(0,ListaTodasQuestoes.Count -1);

    QuestaoAtual = ListaTodasQuestoes [numRandomico];

    while (ListaTodasQuestoesRespondidas.Contains (QuestaoAtual))
    {
      numRandomico= Random.Shared.Next (0,ListaTodasQuestoes.Count -1);
      QuestaoAtual = ListaTQuestoes [numRandomico];
    }
    ListaTodasQuestoesRespondidas.Add(QuestaoAtual);

    QuestaoAtual.Desenhar();
  }
  {
    var numRandomico = Random.Shared.Next(0, ListaTodasQuestoes.Count - 1);
    while (ListaTodasQuestoesRespondidas.Contains(numRandomico))
      numRandomico = Random.Shared.Next(0, ListaTodasQuestoes.Count - 1);
    ListaTodasQuestoesRespondidas.Add(numRandomico);
    questaoCorrente = ListaTodasQuestoes[numRandomico];
    questaoCorrente.Desenhar();
  }
  int NivelCorrente = 0;



  public async void VerificarCorreto(int resposta)
  {
    if (questaoCorrente!.VerifiicarResposta(resposta))
    {
      await Task.Delay(1500);
      labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
    labelNivel.Text = "Nivel:" + NivelAtual.ToString();
      AdicionaPontuacao(NivelAtual);
       NivelAtual++;       
      ProximaPergunta();
      if (NivelAtual== 10)
      {
        Application.Current.MainPage = new FimJogoPage();
      }
    }
    else
    {
      await App.Current.MainPage.DisplayAlert("Você errou", "Desistir é para os fracos o ideal é nem tentar,mas você pode tentar de novo", "tentar novante");
      Inicializar();
    }
   


    void AdicionaPontuacao(int n)
    {
      if (n == 1)
        Pontuacao = 1000;
      else if (n == 2)
        Pontuacao = 2000;
      else if (n == 3)
        Pontuacao = 5000;
      else if (n == 4)
        Pontuacao = 10000;
      else if (n == 5)
        Pontuacao = 20000;
      else if (n == 6)
        Pontuacao = 50000;
      else if (n == 7)
        Pontuacao = 10000;
      else if (n == 8)
        Pontuacao = 20000;
      else if (n == 9)
        Pontuacao = 500000;
      else if (n == 10)
        Pontuacao = 100000;
    }

  }

  public int Pontuacao { get; private set; }
  int NivelAtual = 0;

  void Inicializar()
  {
    Pontuacao = 0;
    NivelAtual = 0;
    ProximaPergunta();
    labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
    labelNivel.Text = "Nivel:" + NivelCorrente.ToString();
  }

  void CriarQuestoes(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
  {
    var Q1 = new Questao();
    Q1.Nivel = 4;
    Q1.pergunta = "Quem escreveu Dom Casmurro ?";
    Q1.resposta1 = " Manuel Bandeira";
    Q1.resposta2 = "Jorge Amado";
    Q1.resposta3 = " Machado de Assis";
    Q1.resposta4 = "Clarice Lispector";
    Q1.resposta5 = "Guimarães Rosa";
    Q1.respostacerta = 3;
    Q1.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);

    ListaTodasQuestoes.Add(Q1);

    var Q2 = new Questao();
    Q2.Nivel = 3;
    Q2.pergunta = "Quem pintou a Mona Lisa?";
    Q2.resposta1 = "Michelangelo";
    Q2.resposta2 = "Pablo Picasso";
    Q2.resposta3 = "Leonardo da Vinci";
    Q2.resposta4 = "Vincent van Gogh";
    Q2.resposta5 = "Claude Monet";
    Q2.respostacerta = 3;
    ;
    Q2.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);

    ListaTodasQuestoes.Add(Q2);

    var Q3 = new Questao();
    Q3.Nivel = 3;
    Q3.pergunta = "Qual é o maior planeta do sistema solar?";
    Q3.resposta1 = "Terra";
    Q3.resposta2 = "Júpiter";
    Q3.resposta3 = "Saturno";
    Q3.resposta4 = "Marte";
    Q3.resposta5 = "Vênus";
    Q3.respostacerta = 2;

    Q3.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q3);

    var Q4 = new Questao();
    Q4.Nivel = 2;
    Q4.pergunta = "Qual elemento químico tem o símbolo 'O'?";
    Q4.resposta1 = "Ouro";
    Q4.resposta2 = "Oxigênio";
    Q4.resposta3 = "Ósmio";
    Q4.resposta4 = "Osmônio";
    Q4.resposta5 = "Opala";
    Q4.respostacerta = 2;

    Q4.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q4);

    var Q5 = new Questao();
    Q5.Nivel = 1;
    Q5.pergunta = "Qual é o nome do planeta mais próximo do Sol?";
    Q5.resposta1 = "Vênus";
    Q5.resposta2 = "Marte";
    Q5.resposta3 = "Mercúrio";
    Q5.resposta4 = "Terra";
    Q5.resposta5 = "Júpiter";
    Q5.respostacerta = 3;

    Q5.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q5);

    var Q6 = new Questao();
    Q6.Nivel = 1;
    Q6.pergunta = "Qual é a língua mais falada do mundo?";
    Q6.resposta1 = "Inglês";
    Q6.resposta2 = "Mandarim";
    Q6.resposta3 = "Espanhol";
    Q6.resposta4 = "Hindi";
    Q6.resposta5 = "Árabe";
    Q6.respostacerta = 2;

    Q6.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q6);

    var Q7 = new Questao();
    Q7.Nivel = 1;
    Q7.pergunta = "Qual é o país conhecido como 'Terra do Sol Nascente'?";
    Q7.resposta1 = "China";
    Q7.resposta2 = "Japão";
    Q7.resposta3 = "Coreia do Sul";
    Q7.resposta4 = "Tailândia";
    Q7.resposta5 = "Filipinas";
    Q7.respostacerta = 2;
    Q7.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q7);

    var Q8 = new Questao();
    Q8.Nivel = 1;
    Q8.pergunta = "Qual é o sabor típico do sorvete de flocos?";
    Q8.resposta1 = "Chocolate";
    Q8.resposta2 = "Baunilha";
    Q8.resposta3 = "Morango";
    Q8.resposta4 = "Flocos de chocolate";
    Q8.resposta5 = "Coco";
    Q8.respostacerta = 4;

    Q8.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q8);

    var Q9 = new Questao();
    Q9.Nivel = 3;
    Q9.pergunta = "Qual é o país conhecido pela torre inclinada?";
    Q9.resposta1 = "França";
    Q9.resposta2 = "Espanha";
    Q9.resposta3 = "Itália";
    Q9.resposta4 = "Alemanha";
    Q9.resposta5 = "Brasil";
    Q9.respostacerta = 3;

    Q9.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q9);

    var Q10 = new Questao();
    Q10.Nivel = 2;
    Q10.pergunta = "Qual é o famoso personagem de desenho que tem um cachorro chamado Scooby?";
    Q10.resposta1 = "Tom";
    Q10.resposta2 = "Jerry";
    Q10.resposta3 = "Fred";
    Q10.resposta4 = "Shaggy";
    Q10.resposta5 = "Scooby-Doo";
    Q10.respostacerta = 5;

    Q10.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q10);

    var Q11 = new Questao();
    Q11.Nivel = 1;
    Q11.pergunta = "Qual é o nome do super-herói que veste uma capa e voa pelo céu?";
    Q11.resposta1 = "Batman";
    Q11.resposta2 = "Superman";
    Q11.resposta3 = "Spider-Man";
    Q11.resposta4 = "Homem de Ferro";
    Q11.resposta5 = "Thor";
    Q11.respostacerta = 2;

    Q11.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q11);

    var Q12 = new Questao();
    Q12.Nivel = 2;
    Q12.pergunta = "Qual é a capital da Itália?";
    Q12.resposta1 = "Milão";
    Q12.resposta2 = "Roma";
    Q12.resposta3 = "Nápoles";
    Q12.resposta4 = "Florença";
    Q12.resposta5 = "Veneza";
    Q12.respostacerta = 2;

    Q12.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q12);

var Q13 = new Questao();
    Q13.Nivel = 2;
    Q13.pergunta = "Qual é a capital do Brasil?";
    Q13.resposta1 = "Curitiba";
    Q13.resposta2 = "Brasilia";
    Q13.resposta3 = "São Paulo";
    Q13.resposta4 = "Salvador";
    Q13.resposta5 = "Minas Gerais";
    Q13.respostacerta = 2;

    Q13.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    ListaTodasQuestoes.Add(Q13);

    var Q14 = new Questao();
Q14.Nivel = 1;
Q14.pergunta = "Qual é o animal que faz 'miau'?";
Q14.resposta1 = "Cachorro";
Q14.resposta2 = "Gato";
Q14.resposta3 = "Cavalo";
Q14.resposta4 = "Pato";
Q14.resposta5 = "Vaca";
Q14.respostacerta = 2;

Q14.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q14);

var Q15 = new Questao();
Q15.Nivel = 1;
Q15.pergunta = "Qual é a cor da grama?";
Q15.resposta1 = "Amarelo";
Q15.resposta2 = "Verde";
Q15.resposta3 = "Azul";
Q15.resposta4 = "Vermelho";
Q15.resposta5 = "Laranja";
Q15.respostacerta = 2;

Q15.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q15);

var Q16 = new Questao();
Q16.Nivel = 1;
Q16.pergunta = "Quantas patas tem um cachorro?";
Q16.resposta1 = "2";
Q16.resposta2 = "3";
Q16.resposta3 = "4";
Q16.resposta4 = "5";
Q16.resposta5 = "6";
Q16.respostacerta = 3;

Q16.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q16);

var Q17 = new Questao();
Q17.Nivel = 1;
Q17.pergunta = "Qual é a estação do ano que geralmente faz mais frio?";
Q17.resposta1 = "Primavera";
Q17.resposta2 = "Verão";
Q17.resposta3 = "Outono";
Q17.resposta4 = "Inverno";
Q17.resposta5 = "Nenhuma";
Q17.respostacerta = 4;

Q17.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q17);

var Q18 = new Questao();
Q18.Nivel = 1;
Q18.pergunta = "Qual é o alimento que vem de vacas?";
Q18.resposta1 = "Ovos";
Q18.resposta2 = "Leite";
Q18.resposta3 = "Carne";
Q18.resposta4 = "Peixe";
Q18.resposta5 = "Frutas";
Q18.respostacerta = 2;

Q18.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q18);

var Q19 = new Questao();
Q19.Nivel = 2;
Q19.pergunta = "Qual é o menor país do mundo?";
Q19.resposta1 = "Mônaco";
Q19.resposta2 = "Vaticano";
Q19.resposta3 = "San Marino";
Q19.resposta4 = "Nauru";
Q19.resposta5 = "Tuvalu";
Q19.respostacerta = 2;

Q19.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q19);

var Q20 = new Questao();
Q20.Nivel = 2;
Q20.pergunta = "Qual é o principal ingrediente do guacamole?";
Q20.resposta1 = "Tomate";
Q20.resposta2 = "Cebola";
Q20.resposta3 = "Abacate";
Q20.resposta4 = "Limão";
Q20.resposta5 = "Pimenta";
Q20.respostacerta = 3;

Q20.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q20);

var Q21 = new Questao();
Q21.Nivel = 2;
Q21.pergunta = "Quem pintou o teto da Capela Sistina?";
Q21.resposta1 = "Raphael";
Q21.resposta2 = "Caravaggio";
Q21.resposta3 = "Michelangelo";
Q21.resposta4 = "Leonardo da Vinci";
Q21.resposta5 = "Donatello";
Q21.respostacerta = 3;

Q21.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q21);

var Q22 = new Questao();
Q22.Nivel = 2;
Q22.pergunta = "Qual é o maior órgão do corpo humano?";
Q22.resposta1 = "Coração";
Q22.resposta2 = "Fígado";
Q22.resposta3 = "Pele";
Q22.resposta4 = "Cérebro";
Q22.resposta5 = "Pulmões";
Q22.respostacerta = 3;

Q22.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q22);

var Q23 = new Questao();
Q23.Nivel = 2;
Q23.pergunta = "Qual é o processo pelo qual as plantas produzem seu alimento?";
Q23.resposta1 = "Respiração";
Q23.resposta2 = "Fotossíntese";
Q23.resposta3 = "Transpiração";
Q23.resposta4 = "Glicólise";
Q23.resposta5 = "Fermentação";
Q23.respostacerta = 2;

Q23.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q23);

var Q24 = new Questao();
Q24.Nivel = 2;
Q24.pergunta = "Qual é o elemento químico com o símbolo 'Fe'?";
Q24.resposta1 = "Ferro";
Q24.resposta2 = "Flúor";
Q24.resposta3 = "Fósforo";
Q24.resposta4 = "Cálcio";
Q24.resposta5 = "Mercúrio";
Q24.respostacerta = 1;

Q24.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q24);

var Q25 = new Questao();
Q25.Nivel = 2;
Q25.pergunta = "Em que continente fica o Egito?";
Q25.resposta1 = "África";
Q25.resposta2 = "Ásia";
Q25.resposta3 = "Europa";
Q25.resposta4 = "América";
Q25.resposta5 = "Oceania";
Q25.respostacerta = 1;

Q25.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q25);
var Q26 = new Questao();
Q26.Nivel = 3;
Q26.pergunta = "Qual país é famoso pela Torre Eiffel?";
Q26.resposta1 = "Espanha";
Q26.resposta2 = "França";
Q26.resposta3 = "Itália";
Q26.resposta4 = "Alemanha";
Q26.resposta5 = "Reino Unido";
Q26.respostacerta = 2;

Q26.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q26);

var Q27 = new Questao();
Q27.Nivel = 3;
Q27.pergunta = "Qual é o rio mais longo do mundo?";
Q27.resposta1 = "Amazonas";
Q27.resposta2 = "Nilo";
Q27.resposta3 = "Yangtze";
Q27.resposta4 = "Mississippi";
Q27.resposta5 = "Danúbio";
Q27.respostacerta = 1;

Q27.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q27);

var Q28 = new Questao();
Q28.Nivel = 3;
Q28.pergunta = "Qual é a capital da Argentina, conhecida por sua cultura vibrante e tango?";
Q28.resposta1 = "Montevidéu";
Q28.resposta2 = "Santiago";
Q28.resposta3 = "Buenos Aires";
Q28.resposta4 = "Lima";
Q28.resposta5 = "Caracas";
Q28.respostacerta = 3;

Q28.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q28);

var Q29 = new Questao();
Q29.Nivel = 3;
Q29.pergunta = "Qual famoso livro começa com a frase 'Todas as famílias felizes se parecem umas com as outras'?";
Q29.resposta1 = "Crime e Castigo";
Q29.resposta2 = "Anna Kariênina";
Q29.resposta3 = "Orgulho e Preconceito";
Q29.resposta4 = "O Grande Gatsby";
Q29.resposta5 = "Moby Dick";
Q29.respostacerta = 2;

Q29.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q29);

var Q30 = new Questao();
Q30.Nivel = 3;
Q30.pergunta = "Qual é o nome do famoso escritor britânico que criou Harry Potter?";
Q30.resposta1 = "J.R.R. Tolkien";
Q30.resposta2 = "George Orwell";
Q30.resposta3 = "J.K. Rowling";
Q30.resposta4 = "C.S. Lewis";
Q30.resposta5 = "Agatha Christie";
Q30.respostacerta = 3;

Q30.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q30);

var Q31 = new Questao();
Q31.Nivel = 3;
Q31.pergunta = "Quem compôs a famosa sinfonia 'Nona Sinfonia', também conhecida como 'Ode à Alegria'?";
Q31.resposta1 = "Johann Sebastian Bach";
Q31.resposta2 = "Ludwig van Beethoven";
Q31.resposta3 = "Wolfgang Amadeus Mozart";
Q31.resposta4 = "Frédéric Chopin";
Q31.resposta5 = "Richard Wagner";
Q31.respostacerta = 2;

Q31.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q31);

var Q32 = new Questao();
Q32.Nivel = 3;
Q32.pergunta = "Qual é a famosa canção de John Lennon que fala sobre paz e unidade?";
Q32.resposta1 = "Imagine";
Q32.resposta2 = "Hey Jude";
Q32.resposta3 = "Let It Be";
Q32.resposta4 = "Yesterday";
Q32.resposta5 = "All You Need Is Love";
Q32.respostacerta = 1;

Q32.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q32);

var Q33 = new Questao();
Q33.Nivel = 4;
Q33.pergunta = "Qual é o famoso festival de música que acontece anualmente em Chicago, conhecido por sua diversidade e clima festivo?";
Q33.resposta1 = "Lollapalooza";
Q33.resposta2 = "Coachella";
Q33.resposta3 = "Glastonbury";
Q33.resposta4 = "Tomorrowland";
Q33.resposta5 = "Woodstock";
Q33.respostacerta = 1;

Q33.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q33);

var Q34 = new Questao();
Q34.Nivel = 4;
Q34.pergunta = "Quem escreveu a peça 'Romeu e Julieta', uma das histórias de amor mais conhecidas do mundo?";
Q34.resposta1 = "Charles Dickens";
Q34.resposta2 = "William Shakespeare";
Q34.resposta3 = "Leo Tolstoy";
Q34.resposta4 = "Herman Melville";
Q34.resposta5 = "George Orwell";
Q34.respostacerta = 2;

Q34.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q34);

var Q35 = new Questao();
Q35.Nivel = 4;
Q35.pergunta = "Qual é o nome do famoso templo localizado em Angkor Wat, no Camboja, que é considerado uma das maiores maravilhas arquitetônicas do mundo?";
Q35.resposta1 = "Templo de Mysores";
Q35.resposta2 = "Templo do Lorax";
Q35.resposta3 = "Angkor Wat";
Q35.resposta4 = "Machu Picchu";
Q35.resposta5 = "Petra";
Q35.respostacerta = 3;

Q35.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q35);

var Q36 = new Questao();
Q36.Nivel = 4;
Q36.pergunta = "Qual é a obra famosa do artista Vincent van Gogh que retrata um céu noturno estrelado?";
Q36.resposta1 = "A Noite Estrelada";
Q36.resposta2 = "Girassóis";
Q36.resposta3 = "O Quarto";
Q36.resposta4 = "Noite de Estrelas";
Q36.resposta5 = "O Cafe da Manhã";
Q36.respostacerta = 1;

Q36.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q36);

var Q37 = new Questao();
Q37.Nivel = 4;
Q37.pergunta = "Qual é o famoso monumento de pedra que se localiza na Inglaterra e é um mistério arqueológico?";
Q37.resposta1 = "Stonehenge";
Q37.resposta2 = "Machu Picchu";
Q37.resposta3 = "Cristo Redentor";
Q37.resposta4 = "As Pirâmides de Gizé";
Q37.resposta5 = "O Coliseu";
Q37.respostacerta = 1;

Q37.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q37);

var Q38 = new Questao();
Q38.Nivel = 4;
Q38.pergunta = "Qual é o famoso romance distópico escrito por Aldous Huxley, que explora temas de controle social e tecnologia?";
Q38.resposta1 = "1984";
Q38.resposta2 = "Fahrenheit 451";
Q38.resposta3 = "Admirável Mundo Novo";
Q38.resposta4 = "A Revolução dos Bichos";
Q38.resposta5 = "O Conto da Aia";
Q38.respostacerta = 3;


Q38.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q38);

var Q39 = new Questao();
Q39.Nivel = 4;
Q39.pergunta = "Qual é a famosa pintura de Edvard Munch que retrata uma figura expressando angústia e desespero?";
Q39.resposta1 = "O Grito";
Q39.resposta2 = "A Persistência da Memória";
Q39.resposta3 = "O Nascimento de Vênus";
Q39.resposta4 = "O Beijo";
Q39.resposta5 = "A Noite Estrelada";
Q39.respostacerta = 1;

Q39.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q39);

var Q40 = new Questao();
Q40.Nivel = 4;
Q40.pergunta = "Qual é o nome da famosa dança tradicional da Índia que combina música, dança e drama?";
Q40.resposta1 = "Samba";
Q40.resposta2 = "Flamenco";
Q40.resposta3 = "Bharatanatyam";
Q40.resposta4 = "Tango";
Q40.resposta5 = "Ballet";
Q40.respostacerta = 3;

Q40.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q40);

var Q41 = new Questao();
Q41.Nivel = 5;
Q41.pergunta = "Qual foi a principal consequência da Revolução Industrial?";
Q41.resposta1 = "Aumento da produção agrícola";
Q41.resposta2 = "Crescimento das cidades e do proletariado";
Q41.resposta3 = "Fortalecimento das monarquias absolutistas";
Q41.resposta4 = "Diminuição do comércio internacional";
Q41.resposta5 = "Abolição da escravidão";
Q41.respostacerta = 2;

Q41.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q41);

var Q42 = new Questao();
Q42.Nivel = 5;
Q42.pergunta = "Qual evento marcou o início da Primeira Guerra Mundial?";
Q42.resposta1 = "A Revolução Russa";
Q42.resposta2 = "O assassinato do arquiduque Francisco Ferdinando";
Q42.resposta3 = "A invasão da Polônia";
Q42.resposta4 = "A Conferência de Paz de Paris";
Q42.resposta5 = "O Tratado de Versalhes";
Q42.respostacerta = 2;

Q42.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q42);

var Q43 = new Questao();
Q43.Nivel = 5;
Q43.pergunta = "Qual foi o principal resultado da Conferência de Berlim (1884-1885)?";
Q43.resposta1 = "A divisão da África entre potências europeias";
Q43.resposta2 = "O fortalecimento da Liga das Nações";
Q43.resposta3 = "A independência da Índia";
Q43.resposta4 = "O fim do colonialismo";
Q43.resposta5 = "A criação da ONU";
Q43.respostacerta = 1;

Q43.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q43);

var Q44 = new Questao();
Q44.Nivel = 5;
Q44.pergunta = "Quem foi o primeiro presidente da República do Brasil?";
Q44.resposta1 = "Getúlio Vargas";
Q44.resposta2 = "Washington Luís";
Q44.resposta3 = "Deodoro da Fonseca";
Q44.resposta4 = "Juscelino Kubitschek";
Q44.resposta5 = "Fernando Henrique Cardoso";
Q44.respostacerta = 3;

Q44.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q44);

var Q45 = new Questao();
Q45.Nivel = 5;
Q45.pergunta = "Qual tratado encerrou a Primeira Guerra Mundial?";
Q45.resposta1 = "Tratado de Versalhes";
Q45.resposta2 = "Tratado de Trianon";
Q45.resposta3 = "Tratado de Saint-Germain";
Q45.resposta4 = "Tratado de Paris";
Q45.resposta5 = "Tratado de Potsdam";
Q45.respostacerta = 1;

Q45.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q45);

var Q46 = new Questao();
Q46.Nivel = 5;
Q46.pergunta = "Qual foi o principal objetivo da Liga das Nações?";
Q46.resposta1 = "Promover a guerra entre nações";
Q46.resposta2 = "Prevenir futuros conflitos e promover a paz";
Q46.resposta3 = "Unificar a Europa";
Q46.resposta4 = "Apoiar a Revolução Industrial";
Q46.resposta5 = "Colonizar a África";
Q46.respostacerta = 2;

Q46.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q46);

var Q47 = new Questao();
Q47.Nivel = 5;
Q47.pergunta = "O que foi o Movimento Modernista no Brasil, iniciado em 1922?";
Q47.resposta1 = "Uma revolta contra a ditadura";
Q47.resposta2 = "Um movimento artístico e cultural";
Q47.resposta3 = "Uma guerra de independência";
Q47.resposta4 = "Um movimento político de esquerda";
Q47.resposta5 = "Uma revolução industrial";
Q47.respostacerta = 2;

Q47.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q47);

var Q48 = new Questao();
Q48.Nivel = 5;
Q48.pergunta = "Quem foi o principal responsável pela abolição da escravatura no Brasil?";
Q48.resposta1 = "Dom Pedro II";
Q48.resposta2 = "José do Patrocínio";
Q48.resposta3 = "Tiradentes";
Q48.resposta4 = "Joaquim Nabuco";
Q48.resposta5 = "Zumbi dos Palmares";
Q48.respostacerta = 4;

Q48.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q48);

var Q49 = new Questao();
Q49.Nivel = 5;
Q49.pergunta = "Qual foi a principal característica do regime militar brasileiro de 1964 a 1985?";
Q49.resposta1 = "Liberdade de expressão";
Q49.resposta2 = "Repressão política e censura";
Q49.resposta3 = "Democratização imediata";
Q49.resposta4 = "Abolição da escravidão";
Q49.resposta5 = "Desenvolvimento econômico sustentável";
Q49.respostacerta = 2;

Q49.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q49);

var Q50 = new Questao();
Q50.Nivel = 5;
Q50.pergunta = "Qual foi a causa da crise de 1929?";
Q50.resposta1 = "A Segunda Guerra Mundial";
Q50.resposta2 = "Superprodução e especulação na bolsa de valores";
Q50.resposta3 = "Abolição da escravidão";
Q50.resposta4 = "Revolução Industrial";
Q50.resposta5 = "A guerra do Vietnã";
Q50.respostacerta = 2;

Q50.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q50);

var Q51 = new Questao();
Q51.Nivel = 6;
Q51.pergunta = "Qual é a principal função da mitocôndria na célula?";
Q51.resposta1 = "Síntese de proteínas";
Q51.resposta2 = "Produção de energia (ATP)";
Q51.resposta3 = "Armazenamento de lipídios";
Q51.resposta4 = "Síntese de hormônios";
Q51.resposta5 = "Replicação do DNA";
Q51.respostacerta = 2;

Q51.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q51);

var Q52 = new Questao();
Q52.Nivel = 6;
Q52.pergunta = "Qual é o processo de conversão da luz solar em energia química?";
Q52.resposta1 = "Respiração celular";
Q52.resposta2 = "Fermentação";
Q52.resposta3 = "Fotossíntese";
Q52.resposta4 = "Glicólise";
Q52.resposta5 = "Quimiossíntese";
Q52.respostacerta = 3;

Q52.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q52);

var Q53 = new Questao();
Q53.Nivel = 6;
Q53.pergunta = "O que são os genes?";
Q53.resposta1 = "Unidades de hereditariedade que determinam características";
Q53.resposta2 = "Células responsáveis pela defesa do organismo";
Q53.resposta3 = "Moléculas que transportam oxigênio no sangue";
Q53.resposta4 = "Proteínas que aceleram reações químicas";
Q53.resposta5 = "Partículas subatômicas";
Q53.respostacerta = 1;

Q53.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q53);

var Q54 = new Questao();
Q54.Nivel = 6;
Q54.pergunta = "Qual é o principal componente da membrana celular?";
Q54.resposta1 = "Carboidratos";
Q54.resposta2 = "Proteínas";
Q54.resposta3 = "Ácidos nucleicos";
Q54.resposta4 = "Fosfolipídios";
Q54.resposta5 = "Vitaminas";
Q54.respostacerta = 4;

Q54.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q54);

var Q55 = new Questao();
Q55.Nivel = 6;
Q55.pergunta = "Qual é a capital da Nova Zelândia?";
Q55.resposta1 = "Auckland";
Q55.resposta2 = "Wellington";
Q55.resposta3 = "Christchurch";
Q55.resposta4 = "Hamilton";
Q55.resposta5 = "Dunedin";
Q55.respostacerta = 2;

Q55.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q55);

var Q56 = new Questao();
Q56.Nivel = 6;
Q56.pergunta = "Qual elemento químico é representado pelo símbolo 'Au'?";
Q56.resposta1 = "Prata";
Q56.resposta2 = "Ouro";
Q56.resposta3 = "Alumínio";
Q56.resposta4 = "Argônio";
Q56.resposta5 = "Cobre";
Q56.respostacerta = 2;

Q56.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q56);

var Q57 = new Questao();
Q57.Nivel = 6;
Q57.pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
Q57.resposta1 = "Abraham Lincoln";
Q57.resposta2 = "George Washington";
Q57.resposta3 = "Thomas Jefferson";
Q57.resposta4 = "Franklin D. Roosevelt";
Q57.resposta5 = "John Adams";
Q57.respostacerta = 2;

Q57.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q57);

var Q58 = new Questao();
Q58.Nivel = 6;
Q58.pergunta = "Qual é a obra mais famosa de Leonardo da Vinci?";
Q58.resposta1 = "A Última Ceia";
Q58.resposta2 = "A Monalisa";
Q58.resposta3 = "O Nascimento de Vênus";
Q58.resposta4 = "A Criação de Adão";
Q58.resposta5 = "O Grito";
Q58.respostacerta = 2;

Q58.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q58);

var Q59 = new Questao();
Q59.Nivel = 6;
Q59.pergunta = "Qual é a montanha mais alta do mundo?";
Q59.resposta1 = "K2";
Q59.resposta2 = "Kangchenjunga";
Q59.resposta3 = "Lhotse";
Q59.resposta4 = "Everest";
Q59.resposta5 = "Makalu";
Q59.respostacerta = 4;

Q59.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q59);

var Q60 = new Questao();
Q60.Nivel = 6;
Q60.pergunta = "Qual é o processo pelo qual os organismos se adaptam ao seu ambiente ao longo do tempo?";
Q60.resposta1 = "Mutação";
Q60.resposta2 = "Seleção natural";
Q60.resposta3 = "Reprodução assexuada";
Q60.resposta4 = "Especiação";
Q60.resposta5 = "Translocação";
Q60.respostacerta = 2;

Q60.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q60);

var Q61 = new Questao();
Q61.Nivel = 7;
Q61.pergunta = "Qual é o principal responsável pela fotossíntese nas plantas?";
Q61.resposta1 = "Clorofila";
Q61.resposta2 = "Carotenoides";
Q61.resposta3 = "Estômatos";
Q61.resposta4 = "Raízes";
Q61.resposta5 = "Flores";
Q61.respostacerta = 1;

Q61.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q61);

var Q62 = new Questao();
Q62.Nivel = 7;
Q62.pergunta = "Qual civilização é conhecida por desenvolver a escrita cuneiforme?";
Q62.resposta1 = "Egípcios";
Q62.resposta2 = "Sumérios";
Q62.resposta3 = "Fenícios";
Q62.resposta4 = "Gregos";
Q62.resposta5 = "Romanos";
Q62.respostacerta = 2;

Q62.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q62);

var Q63 = new Questao();
Q63.Nivel = 7;
Q63.pergunta = "Qual a principal função dos ribossomos na célula?";
Q63.resposta1 = "Síntese de lipídios";
Q63.resposta2 = "Armazenamento de energia";
Q63.resposta3 = "Produção de proteínas";
Q63.resposta4 = "Replicação do DNA";
Q63.resposta5 = "Transporte de substâncias";
Q63.respostacerta = 3;

Q63.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q63);

var Q64 = new Questao();
Q64.Nivel = 7;
Q64.pergunta = "Quem foi o líder da Revolução Cubana em 1959?";
Q64.resposta1 = "Fidel Castro";
Q64.resposta2 = "Ernesto Che Guevara";
Q64.resposta3 = "Raúl Castro";
Q64.resposta4 = "Mao Zedong";
Q64.resposta5 = "Augusto Pinochet";
Q64.respostacerta = 1;

Q64.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q64);

var Q65 = new Questao();
Q65.Nivel = 7;
Q65.pergunta = "Qual é a maior floresta tropical do mundo?";
Q65.resposta1 = "Floresta Amazônica";
Q65.resposta2 = "Floresta do Congo";
Q65.resposta3 = "Floresta Boreal";
Q65.resposta4 = "Floresta de Taiga";
Q65.resposta5 = "Floresta Valdiviana";
Q65.respostacerta = 1;

Q65.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q65);

var Q66 = new Questao();
Q66.Nivel = 7;
Q66.pergunta = "Qual foi a principal inovação trazida pela Revolução Industrial?";
Q66.resposta1 = "Agricultura de subsistência";
Q66.resposta2 = "Máquinas a vapor";
Q66.resposta3 = "Energia solar";
Q66.resposta4 = "Transporte marítimo";
Q66.resposta5 = "Comunicação por telégrafo";
Q66.respostacerta = 2;

Q66.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q66);

var Q67 = new Questao();
Q67.Nivel = 7;
Q67.pergunta = "Qual é o principal autor do livro 'O Capital'?";
Q67.resposta1 = "Adam Smith";
Q67.resposta2 = "Karl Marx";
Q67.resposta3 = "Friedrich Engels";
Q67.resposta4 = "John Maynard Keynes";
Q67.resposta5 = "Milton Friedman";
Q67.respostacerta = 2;

Q67.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q67);

var Q68 = new Questao();
Q68.Nivel = 7;
Q68.pergunta = "Qual é o sistema utilizado para classificar os organismos vivos?";
Q68.resposta1 = "Sistema binomial";
Q68.resposta2 = "Sistema métrico";
Q68.resposta3 = "Sistema decimal";
Q68.resposta4 = "Sistema de coordenadas";
Q68.resposta5 = "Sistema hexadecimal";
Q68.respostacerta = 1;

Q68.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q68);

var Q69 = new Questao();
Q69.Nivel = 7;
Q69.pergunta = "Qual artista é conhecido por suas obras do movimento surrealista?";
Q69.resposta1 = "Pablo Picasso";
Q69.resposta2 = "Salvador Dalí";
Q69.resposta3 = "Vincent van Gogh";
Q69.resposta4 = "Claude Monet";
Q69.resposta5 = "Henri Matisse";
Q69.respostacerta = 2;

Q69.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q69);

var Q70 = new Questao();
Q70.Nivel = 7;
Q70.pergunta = "Qual é a teoria que descreve a deriva dos continentes?";
Q70.resposta1 = "Teoria da Tectônica de Placas";
Q70.resposta2 = "Teoria da Evolução";
Q70.resposta3 = "Teoria da Relatividade";
Q70.resposta4 = "Teoria da Criação";
Q70.resposta5 = "Teoria da Uniformidade";
Q70.respostacerta = 1;

Q70.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q70);

var Q71 = new Questao();
Q71.Nivel = 8;
Q71.pergunta = "Qual é a única parte do corpo humano que não se regenera?";
Q71.resposta1 = "Coração";
Q71.resposta2 = "Cérebro";
Q71.resposta3 = "Dente";
Q71.resposta4 = "Olhos";
Q71.resposta5 = "Fígado";
Q71.respostacerta = 4;

Q71.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q71);

var Q72 = new Questao();
Q72.Nivel = 8;
Q72.pergunta = "Quem é conhecido como o 'pai da história'?";
Q72.resposta1 = "Heródoto";
Q72.resposta2 = "Tucídides";
Q72.resposta3 = "Platão";
Q72.resposta4 = "Aristóteles";
Q72.resposta5 = "Sócrates";
Q72.respostacerta = 1;

Q72.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q72);

var Q73 = new Questao();
Q73.Nivel = 8;
Q73.pergunta = "Qual elemento químico tem o símbolo 'Au'?";
Q73.resposta1 = "Prata";
Q73.resposta2 = "Ouro";
Q73.resposta3 = "Alumínio";
Q73.resposta4 = "Cobre";
Q73.resposta5 = "Ferro";
Q73.respostacerta = 2;

Q73.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q73);

var Q74 = new Questao();
Q74.Nivel = 8;
Q74.pergunta = "Qual foi a primeira civilização a desenvolver a escrita?";
Q74.resposta1 = "Egípcios";
Q74.resposta2 = "Sumérios";
Q74.resposta3 = "Fenícios";
Q74.resposta4 = "Chineses";
Q74.resposta5 = "Gregos";
Q74.respostacerta = 2;

Q74.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q74);

var Q75 = new Questao();
Q75.Nivel = 8;
Q75.pergunta = "Qual é a capital da Nova Zelândia?";
Q75.resposta1 = "Auckland";
Q75.resposta2 = "Wellington";
Q75.resposta3 = "Christchurch";
Q75.resposta4 = "Hamilton";
Q75.resposta5 = "Dunedin";
Q75.respostacerta = 2;

Q75.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q75);

var Q76 = new Questao();
Q76.Nivel = 8;
Q76.pergunta = "Qual foi o primeiro país a conceder o direito de voto às mulheres?";
Q76.resposta1 = "Estados Unidos";
Q76.resposta2 = "Nova Zelândia";
Q76.resposta3 = "Reino Unido";
Q76.resposta4 = "Finlândia";
Q76.resposta5 = "Suécia";
Q76.respostacerta = 2;

Q76.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q76);

var Q77 = new Questao();
Q77.Nivel = 8;
Q77.pergunta = "Qual é o continente com a maior área territorial?";
Q77.resposta1 = "África";
Q77.resposta2 = "Ásia";
Q77.resposta3 = "América do Sul";
Q77.resposta4 = "América do Norte";
Q77.resposta5 = "Antártica";
Q77.respostacerta = 2;

Q77.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q77);

var Q78 = new Questao();
Q78.Nivel = 8;
Q78.pergunta = "Quem pintou 'A Última Ceia'?";
Q78.resposta1 = "Michelangelo";
Q78.resposta2 = "Leonardo da Vinci";
Q78.resposta3 = "Raphael";
Q78.resposta4 = "Vincent van Gogh";
Q78.resposta5 = "Pablo Picasso";
Q78.respostacerta = 2;

Q78.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q78);

var Q79 = new Questao();
Q79.Nivel = 8;
Q79.pergunta = "Qual é o maior oceano do mundo?";
Q79.resposta1 = "Oceano Atlântico";
Q79.resposta2 = "Oceano Índico";
Q79.resposta3 = "Oceano Ártico";
Q79.resposta4 = "Oceano Pacífico";
Q79.resposta5 = "Oceano Antártico";
Q79.respostacerta = 4;

Q79.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q79);
var Q80 = new Questao();
Q80.Nivel = 8;
Q80.pergunta = "Qual é o nome do conceito que descreve a possibilidade de que exista vida em outros planetas?";
Q80.resposta1 = "Xenobiologia";
Q80.resposta2 = "Astrobiologia";
Q80.resposta3 = "Biologia Exoplanetária";
Q80.resposta4 = "Astrofísica";
Q80.resposta5 = "Cosmologia";
Q80.respostacerta = 2;

Q80.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q80);

var Q81 = new Questao();
Q81.Nivel = 9;
Q81.pergunta = "Qual é o termo que descreve a interdependência entre as espécies em um ecossistema?";
Q81.resposta1 = "Simbiose";
Q81.resposta2 = "Mutualismo";
Q81.resposta3 = "Comensalismo";
Q81.resposta4 = "Ecologia";
Q81.resposta5 = "Biodiversidade";
Q81.respostacerta = 4;

Q81.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q81);

var Q82 = new Questao();
Q82.Nivel = 9;
Q82.pergunta = "Qual fenômeno físico é responsável pela mudança de cor do céu durante o pôr do sol?";
Q82.resposta1 = "Refração da luz";
Q82.resposta2 = "Dispersão da luz";
Q82.resposta3 = "Reflexão da luz";
Q82.resposta4 = "Absorção da luz";
Q82.resposta5 = "Difração da luz";
Q82.respostacerta = 2;

Q82.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q82);

var Q83 = new Questao();
Q83.Nivel = 9;
Q83.pergunta = "Qual obra de arte é considerada um ícone do Renascimento e representa a figura de uma mulher misteriosa?";
Q83.resposta1 = "A Criação de Adão";
Q83.resposta2 = "A Última Ceia";
Q83.resposta3 = "Mona Lisa";
Q83.resposta4 = "O Nascimento de Vênus";
Q83.resposta5 = "A Escola de Atenas";
Q83.respostacerta = 3;

Q83.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q83);

var Q84 = new Questao();
Q84.Nivel = 9;
Q84.pergunta = "Qual autor escreveu 'Cem Anos de Solidão', um marco da literatura mágica?";
Q84.resposta1 = "Jorge Luis Borges";
Q84.resposta2 = "Gabriel García Márquez";
Q84.resposta3 = "Pablo Neruda";
Q84.resposta4 = "Julio Cortázar";
Q84.resposta5 = "Mario Vargas Llosa";
Q84.respostacerta = 2;

Q84.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q84);

var Q85 = new Questao();
Q85.Nivel = 9;
Q85.pergunta = "Qual é a origem do nome 'Brasil'?";
Q85.resposta1 = "Uma árvore chamada pau-brasil";
Q85.resposta2 = "Uma palavra indígena que significa terra";
Q85.resposta3 = "Um termo grego que significa ouro";
Q85.resposta4 = "Uma referência à cor vermelha";
Q85.resposta5 = "Um nome de origem africana";
Q85.respostacerta = 1;

Q85.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q85);

var Q86 = new Questao();
Q86.Nivel = 9;
Q86.pergunta = "Qual a importância do Acordo de Paris de 2015?";
Q86.resposta1 = "Estabelecer regras de comércio internacional";
Q86.resposta2 = "Limitar o aquecimento global a menos de 2°C";
Q86.resposta3 = "Reforçar alianças militares";
Q86.resposta4 = "Promover a exploração do espaço";
Q86.resposta5 = "Aumentar a produção de energia nuclear";
Q86.respostacerta = 2;

Q86.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q86);
var Q87 = new Questao();
Q87.Nivel = 9;
Q87.pergunta = "Qual é o fenômeno natural que causa a aurora boreal?";
Q87.resposta1 = "Ventos solares";
Q87.resposta2 = "Terremotos";
Q87.resposta3 = "Erupções vulcânicas";
Q87.resposta4 = "Tsunamis";
Q87.resposta5 = "Nuvens de poeira";
Q87.respostacerta = 1;

Q87.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q87);

var Q88 = new Questao();
Q88.Nivel = 9;
Q88.pergunta = "Qual é o nome do conceito que descreve a diversidade de espécies em um ecossistema?";
Q88.resposta1 = "Biodiversidade";
Q88.resposta2 = "Sustentabilidade";
Q88.resposta3 = "Ecosistema";
Q88.resposta4 = "Bioma";
Q88.resposta5 = "Ecologia";
Q88.respostacerta = 1;

Q88.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q88);

var Q89 = new Questao();
Q89.Nivel = 9;
Q89.pergunta = "Qual invenção é creditada a Thomas Edison?";
Q89.resposta1 = "Telefone";
Q89.resposta2 = "Lâmpada elétrica";
Q89.resposta3 = "Computador";
Q89.resposta4 = "Televisão";
Q89.resposta5 = "Radio";
Q89.respostacerta = 2;

Q89.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q89);

var Q90 = new Questao();
Q90.Nivel = 9;
Q90.pergunta = "Qual é o maior deserto do mundo?";
Q90.resposta1 = "Deserto do Saara";
Q90.resposta2 = "Deserto de Gobi";
Q90.resposta3 = "Deserto da Antártida";
Q90.resposta4 = "Deserto do Atacama";
Q90.resposta5 = "Deserto de Kalahari";
Q90.respostacerta = 3;

Q90.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q90);

var Q91 = new Questao();
Q91.Nivel = 10;
Q91.pergunta = "Qual é o único continente sem répteis nativos?";
Q91.resposta1 = "África";
Q91.resposta2 = "Antártica";
Q91.resposta3 = "Oceania";
Q91.resposta4 = "América do Sul";
Q91.resposta5 = "Europa";
Q91.respostacerta = 2;

Q91.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q91);

var Q92 = new Questao();
Q92.Nivel = 10;
Q92.pergunta = "Quem foi o primeiro presidente dos Estados Unidos a ser impeached?";
Q92.resposta1 = "George Washington";
Q92.resposta2 = "Andrew Johnson";
Q92.resposta3 = "Richard Nixon";
Q92.resposta4 = "Bill Clinton";
Q92.resposta5 = "John F. Kennedy";
Q92.respostacerta = 2;

Q92.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q92);

var Q93 = new Questao();
Q93.Nivel = 10;
Q93.pergunta = "Qual é a única planta conhecida por ser capaz de se alimentar de carne?";
Q93.resposta1 = "Venus flytrap";
Q93.resposta2 = "Pitcher plant";
Q93.resposta3 = "Sundew";
Q93.resposta4 = "Butterwort";
Q93.resposta5 = "Todas as anteriores";
Q93.respostacerta = 5;

Q93.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q93);

var Q94 = new Questao();
Q94.Nivel = 10;
Q94.pergunta = "Qual é a teoria que explica a origem do universo?";
Q94.resposta1 = "Teoria do Big Bang";
Q94.resposta2 = "Teoria da Evolução";
Q94.resposta3 = "Teoria da Relatividade";
Q94.resposta4 = "Teoria Quântica";
Q94.resposta5 = "Teoria do Caos";
Q94.respostacerta = 1;

Q94.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q94);

var Q95 = new Questao();
Q95.Nivel = 10;
Q95.pergunta = "Qual civilização antiga é conhecida por suas pirâmides e esfinges?";
Q95.resposta1 = "Sumérios";
Q95.resposta2 = "Gregos";
Q95.resposta3 = "Egípcios";
Q95.resposta4 = "Maia";
Q95.resposta5 = "Persas";
Q95.respostacerta = 3;

Q95.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q95);

var Q96 = new Questao();
Q96.Nivel = 10;
Q96.pergunta = "Qual é a obra mais famosa de Pablo Picasso?";
Q96.resposta1 = "O Grito";
Q96.resposta2 = "Guernica";
Q96.resposta3 = "A Última Ceia";
Q96.resposta4 = "A Persistência da Memória";
Q96.resposta5 = "O Nascimento de Vênus";
Q96.respostacerta = 2;

Q96.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q96);

var Q97 = new Questao();
Q97.Nivel = 10;
Q97.pergunta = "Qual é o maior deserto do mundo?";
Q97.resposta1 = "Deserto do Saara";
Q97.resposta2 = "Deserto de Gobi";
Q97.resposta3 = "Deserto da Antártica";
Q97.resposta4 = "Deserto da Arábia";
Q97.resposta5 = "Deserto de Kalahari";
Q97.respostacerta = 3;

Q97.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q97);

var Q98 = new Questao();
Q98.Nivel = 10;
Q98.pergunta = "Qual país é conhecido como a terra dos cangurus?";
Q98.resposta1 = "Nova Zelândia";
Q98.resposta2 = "África do Sul";
Q98.resposta3 = "Austrália";
Q98.resposta4 = "Canadá";
Q98.resposta5 = "Índia";
Q98.respostacerta = 3;

Q98.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q98);

var Q99 = new Questao();
Q99.Nivel = 10;
Q99.pergunta = "Qual é a capital da Islândia?";
Q99.resposta1 = "Reykjavik";
Q99.resposta2 = "Oslo";
Q99.resposta3 = "Copenhague";
Q99.resposta4 = "Helsinque";
Q99.resposta5 = "Estocolmo";
Q99.respostacerta = 1;

Q99.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q99);

var Q100 = new Questao();
Q100.Nivel = 10;
Q100.pergunta = "Qual é a maior estrutura viva do planeta, visível do espaço?";
Q100.resposta1 = "Grande Barreira de Coral";
Q100.resposta2 = "Floresta Amazônica";
Q100.resposta3 = "Corais de Belize";
Q100.resposta4 = "A Grande Muralha da China";
Q100.resposta5 = "O Sistema de Rios do Congo";
Q100.respostacerta = 1;

Q100.ConfigurarEstruturaDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
ListaTodasQuestoes.Add(Q100);



  }

}
