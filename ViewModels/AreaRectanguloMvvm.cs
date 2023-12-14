using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using static Android.Provider.MediaStore.Audio;

namespace ExamenApp.ViewModels
{
    public partial class AreaRectanguloMvvm : ObservableObject
    {
        [ObservableProperty]
        public double bases;

        [ObservableProperty]
        public double altura;

        [ObservableProperty]
        public double area;

        [RelayCommand]
        public void CalcularAreaRectangulo()
        {

            if (Bases != 0 && Altura != 0)
            {
                Area = Bases * Altura;
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Completa los campos", "Aceptar");
            }
        
        }

        [RelayCommand]
        public void Limpiar()
        {
            Bases = 0;
            Altura = 0;
            Area = 0;
        }

    }
}
