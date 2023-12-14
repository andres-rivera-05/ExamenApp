using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ExamenApp.ViewModels
{
    public partial class AreaCirculoMvvm : ObservableObject
    {
        [ObservableProperty] 
        public double area;

        [ObservableProperty]
        public double radio;

        [ObservableProperty]
        public double resultado;


    }
}
