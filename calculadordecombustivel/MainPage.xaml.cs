namespace calculadordecombustivel
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }
        // button clicked criado automaticamente
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text); // faiz os calculos de combustivel 
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                String msg = "";
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                if(etanol <= (gasolina * 0.7))
                {
                    msg = $"o etanol esta compensando para o {marca} do modelo {modelo} .";
                }
                else
                {
                    msg = $"A gasolina esta compensando para o {marca} do modelo {modelo}."; 
                }
                DisplayAlert("Calculado", msg,"OK");
            } catch(Exception ex) // caso de algum erro 
            {
                DisplayAlert("Ops", ex.Message, "fechar");
            }
        }

    }

}
