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

            if ( name.ToString().Equals("elton"))
            {
                Navigation.PushAsync(new TaticoAddToProject()); 

            }else if (name.ToString().Equals("luis"))
            {
                return;
            }else if (name.ToString().Equals("Ash"))
            {

            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}