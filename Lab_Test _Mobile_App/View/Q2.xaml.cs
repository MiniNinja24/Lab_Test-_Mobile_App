using Lab_Test__Mobile_App.Viewmodel;

namespace Lab_Test__Mobile_App.View;

public partial class Q2 : ContentPage
{
    public Q2()
    {
        InitializeComponent();
        BindingContext = new Q2_ViewModel();
    }
}