using Lab_Test__Mobile_App.Viewmodel;
using Microsoft.Maui.Controls;

namespace Lab_Test__Mobile_App.View
{
    public partial class Q1 : ContentPage
    {
        public Q1()
        {
            InitializeComponent();
            BindingContext = new Q1_ViewModel();
        }
    }

}
