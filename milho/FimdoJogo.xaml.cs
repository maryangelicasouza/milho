using Microsoft.Maui.Controls;
using System;

namespace milho
{
    public partial class FimdoJogo : ContentPage
    {
        public FimdoJogo()
        {
            InitializeComponent();
        }

        private void OnButtonvoltarButtonClicked(object sender, EventArgs args)
        {
            // Lógica para voltar ao jogo
            Application.Current.MainPage = new MainPage(); // volta inicioo
        }
    }
}
