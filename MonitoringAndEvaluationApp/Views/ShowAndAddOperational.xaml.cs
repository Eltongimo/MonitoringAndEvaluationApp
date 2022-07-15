using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MonitoringAndEvaluationApp.Models;

namespace MonitoringAndEvaluationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowAndAddOperational : ContentPage
    {

        private Project project;
        
        public ShowAndAddOperational(Project p)
        {
            project = p;
        }

        public ShowAndAddOperational()
        {
            InitializeComponent();
        }

    }
}