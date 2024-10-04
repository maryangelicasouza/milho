using milho;

public class Universitarios: IAjuda
{
   public override void RealizaAjuda (Questao questao)
   {
    var porcentagem =100;
    for (int i =0; i < 5; i ++)
    {
        int numRand=0;
        if(porcentagem > 0)
        {
            numRand =Random.Shared.Next(0, porcentagem);
            porcentagem -= numRand;
        }
        switch(i)
        {
            case 0:
            buttonResposta1.Text += "-" + numRand.ToString() + "%";
            break;
            case 1:
             buttonResposta2.Text += "-" + numRand.ToString() + "%";
             break;
             case 2:
             buttonResposta3.Text += "-" + numRand.ToString() + "%";
             break;
             case 3:
             buttonResposta4.Text += "-" + numRand.ToString() + "%";
             break;
             case 4:
             buttonResposta5.Text += "-" + numRand.ToString() + "%";
             break;
              case 5:
             buttonResposta5.Text += "-" + numRand.ToString() + "%";
             break;


        }
    }
   }
}
