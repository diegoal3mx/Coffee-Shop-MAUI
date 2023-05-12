using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_2P_EX
{
    class CustomVS : VerticalStackLayout
    {
        public static readonly BindableProperty TipoProperty =
            BindableProperty.Create("Tipo", typeof(string), typeof(CustomVS), "");
        public string Tipo
        {
            get => (string)GetValue(TipoProperty);
            set => SetValue(TipoProperty, value);
        }
    }
}