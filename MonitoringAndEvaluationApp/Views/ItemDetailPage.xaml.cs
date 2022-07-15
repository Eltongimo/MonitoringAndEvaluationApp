using MonitoringAndEvaluationApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MonitoringAndEvaluationApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}