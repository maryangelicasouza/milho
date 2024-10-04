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
	void OnPularCliecked(object sender, EventArgs e)
	{
		gerenciador.ProximaPergunta();
		ButtonPula.IsVisible = false;
	}
    
	void Universitarios(object s, EventArgs e)
	{
		var ajuda =new Universitarios();
		ajuda.ConfiguraDesenho(Button1, Button2, Button3, Button4, Button5 );
		ajuda.RealizaAjuda (gerenciador.GetquestaoCorrente());
		( s as ImageButton). IsVisible=false;
	}


}

