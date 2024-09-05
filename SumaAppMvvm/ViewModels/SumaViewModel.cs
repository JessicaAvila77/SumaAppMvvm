using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaViewModel:ObservableObject
    {
        [ObservableProperty]
        private double valor1;

        [ObservableProperty]
        private double valor2;

        [ObservableProperty]
        private double suma;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]

        private void SumaCalcular()
        {
            try
            {
                Suma = Valor1 + Valor2; 

            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }

        }

        [RelayCommand]  
        private void LimpiarSuma()
        {
            Valor1 = 0;
            Valor2 = 0;
            Suma = 0;
        }








    }
}
