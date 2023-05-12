using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_2P_EX
{
    class CustomHS : HorizontalStackLayout
    {
        public static readonly BindableProperty TipoProperty =
            BindableProperty.Create("Tipo", typeof(string), typeof(CustomHS), "");
        public string Tipo
        {
            get => (string)GetValue(TipoProperty);
            set => SetValue(TipoProperty, value);
        }
    }
}
