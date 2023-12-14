using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExamenApp.ViewModels
{
    public partial class AreaCirculoMvvm : ObservableObject
    {
        [ObservableProperty] 
        public double area;

        [ObservableProperty]
        public double radio;

        [RelayCommand]
        public void CalcularAreaCirculo()
        {
            if (Radio != 0)
            {
                Area = Math.PI * Radio * Radio;
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "EL campo del radio esta vacio", "Aceptar");
            }
        }

        [RelayCommand]
        public void Limpiar()
        {
            Radio = 0;
            Area = 0;
        }

    }
}
