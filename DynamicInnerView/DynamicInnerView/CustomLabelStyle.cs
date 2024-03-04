using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicInnerView
{
    public class CustomEntryStyle : BindableObject
    {
        #region Bindable properties
       
        public static readonly BindableProperty TextColorProperty =
         BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CustomEntryStyle), Color.FromRgba(0, 0, 0, 0.87));

  

        public Color TextColor
        {
            get { return (Color)this.GetValue(TextColorProperty); }
            set { this.SetValue(TextColorProperty, value); }
        }

      
        #endregion
    }



   
}
