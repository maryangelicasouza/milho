	namespace milho;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador (labelpergunta, Button1, Button2, Button3, Button4, Button5,labelPontuacao,labelNivel);
		gerenciador.ProximaPergunta();
	}

	void Clicked01(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(1);
	}

	void Clicked02(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(2);
	}

	void Clicked03(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(3);
	}

	void Clicked04(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(4);
	}

	void Clicked05(object sender, EventArgs e)
	{
		gerenciador.VerificarCorreto(5);
	}
	void OnAjudaRerirarCliecked(object s, EventArgs e)
	{
		var ajuda =new RetiraErrada();
		ajuda.ConfiguraDesenho(Button1, Button2, Button3, Button4, Button5 );
		ajuda.RealizaAjuda (gerenciador.GetquestaoCorrente());
		( s as ImageButton). IsVisible=false;
	}
	
	int pulou =0;
	void OnPularCliecked(object s, EventArgs e)
	{
		if (pulou == 0)
		( s as ImageButton). IsVisible = false;
		else 
	
	{
		gerenciador.ProximaPergunta();
		pulou ++;
	}
	}
	int pulou1 =1;
	void OnPularCliecked2(object s, EventArgs e)
	{
		if (pulou1 == 1)
		( s as ImageButton). IsVisible = false;
		else 
	
	{
		gerenciador.ProximaPergunta();
		pulou1 ++;
	}
	}
	int pulou2 =2;
	void OnPularCliecked3(object s, EventArgs e)
	{
		if (pulou2 == 2)
		( s as ImageButton). IsVisible = false;
		else 
	
	{
		gerenciador.ProximaPergunta();
		pulou2 ++;
	}
	}
	
	
    
	void Universitarios(object s, EventArgs e)
	{
		var ajuda =new Universitarios();
		ajuda.ConfiguraDesenho(Button1, Button2, Button3, Button4, Button5 );
		ajuda.RealizaAjuda (gerenciador.GetquestaoCorrente());
		( s as ImageButton). IsVisible=false;
	}


}

