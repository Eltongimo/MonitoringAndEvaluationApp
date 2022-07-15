using MonitoringAndEvaluationApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonitoringAndEvaluationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void Button_Clicked(object sender, EventArgs events)
        {

            var name = usermane.Text;

            // Utilizador Tatico
            if ( name.ToString().Equals("elton"))
            {
                Navigation.PushAsync(new TaticoAddToProject()); 
          
                // Utilizador Operacional
            }else if (name.ToString().Equals("luis"))
            {
                Navigation.PushAsync(new OperationalHome());
            }else if (name.ToString().Equals("Ash"))
            {

            }
        }

    }
}