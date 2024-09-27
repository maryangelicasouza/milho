namespace milho;

public class Questao
{

    public string pergunta;

    public string resposta1;

    public string resposta2;

    public string resposta3;

    public string resposta4;

    public string resposta5;

    public int respostacerta;


    public int Nivel;

    Label labelPergunta;

    Button buttonResposta1;

    Button buttonResposta2;

    Button buttonResposta3;

    Button buttonResposta4;

    Button buttonResposta5;


    public void Desenhar()
    {
        labelPergunta.Text = pergunta;
        buttonResposta1.Text = resposta1;
        buttonResposta2.Text = resposta2;
        buttonResposta3.Text = resposta3;
        buttonResposta4.Text = resposta4;
        buttonResposta5.Text = resposta5;
        
        this.buttonResposta1!.BackgroundColor= Colors.DarkBlue;
        this.buttonResposta1!.TextColor     = Colors.White;
        this.buttonResposta2!.BackgroundColor= Colors.DarkBlue;
        this.buttonResposta2!.TextColor     = Colors.White;
        this.buttonResposta3!.BackgroundColor= Colors.DarkBlue;
        this.buttonResposta3!.TextColor     = Colors.White;
        this.buttonResposta4!.BackgroundColor= Colors.DarkBlue;
        this.buttonResposta4!.TextColor     = Colors.White;
        this.buttonResposta5!.BackgroundColor= Colors.DarkBlue;
        this.buttonResposta5!.TextColor     = Colors.White;
    }

    private Button buttonEscolhido(int respostaescolhida)
    {
        if (respostaescolhida == 1)
            return buttonResposta1;
        else if (respostaescolhida == 2)
            return buttonResposta2;
        else if (respostaescolhida == 3)
            return buttonResposta3;
        else if (respostaescolhida == 4)
            return buttonResposta4;
        else if (respostaescolhida == 5)
            return buttonResposta5;
        else 
            return null;
    }
     public bool VerifiicarResposta(int respostaescolhida)
    {
        if (respostacerta == respostaescolhida)
        {
            var verificacao = buttonEscolhido(respostaescolhida);
            verificacao.BackgroundColor = Colors.Green;
            verificacao.TextColor = Colors.White;
            return true;
        }
        else
        {
            var verificacaoCorreto = buttonEscolhido(respostacerta);
            var verificacaoIncorreto = buttonEscolhido(respostaescolhida);
            verificacaoCorreto.BackgroundColor = Colors.Yellow;
            verificacaoCorreto.TextColor = Colors.Black;
            verificacaoIncorreto.BackgroundColor = Colors.Red;
            verificacaoIncorreto.TextColor = Colors.White;
            return false;
        }
    }
    
    public void ConfigurarEstruturaDesenho(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
    {
        labelPergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;
     
    }

    public Questao()
    {
    }

    public Questao(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
    {
        labelPergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;
     
    }
public class Questao: IEquatable<Questao>
{
    public bool Equals (Questao q)
    {
        return this.Nivel = = q.Nivel;
    }
}
}
