namespace milho;

public class Questao 
{
    public string pergunta;

    public string resposta1;

    public string resposta2;

    public string resposta3;

    public string resposta4;

    public string resposta5;

    public int respostacorreta;

    public int nível;

    Label labelpergunta;

   Button buttonresposta1;

   Button buttonresposta2;

   Button buttonresposta3;

   Button buttonresposta4;

   Button buttonresposta5;

      public void ConfiguraEstruturaDesenho (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            Labelpergunta = labelpergunta;
            ButtonResposta1 = button1;
            ButtonResposta2 = button2;
            ButtonResposta3 = button3;
            ButtonResposta4 = button4;
            ButtonResposta5 = button5;
        }

public void Desenhar()
{
     Labelpergunta.Text = Pergunta;
            ButtonResposta1.Text = Resposta1;
            ButtonResposta2.Text = Resposta2;
            ButtonResposta3.Text = Resposta3;
            ButtonResposta4.Text = Resposta4;
            ButtonResposta5.Text = Resposta5;
}
  private Button QualBTN(int RespostaSelecionada)
        {
            if (RespostaSelecionada == 1)
                return ButtonResposta1;
            else if (RespostaSelecionada == 2)
                return ButtonResposta2;
            else if (RespostaSelecionada == 3)
                return ButtonResposta3;
            else if (RespostaSelecionada == 4)
                return ButtonResposta4;
            else if (RespostaSelecionada == 5)
                return ButtonResposta5;
            else
                return null;

        }
         public bool VerificaResposta(int RespostaSelecionada)
        {
            if (Respostacorreta == RespostaSelecionada)
            {
                var Button = QualBTN(RespostaSelecionada);
                Button.BackgroundColor = Colors.Green;
                return true;
            }
            else
            {
                var ButtonCorreto = QualBTN (Respostacorreta);
                var ButtonIncorreto = QualBTN (RespostaSelecionada);
                ButtonCorreto.BackgroundColor = Colors.Yellow;
                ButtonIncorreto.BackgroundColor = Colors.Red;
                return false;
            }
        }

          public Questao()
        {

        }
        public Questao(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            Labelpergunta = labelpergunta;
            ButtonResposta1 = button1;
            ButtonResposta2 = button2;
            ButtonResposta3 = button3;
            ButtonResposta4 = button4;
            ButtonResposta5 = button5;
        }



}