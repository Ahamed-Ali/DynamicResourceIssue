using Microsoft.Maui.Layouts;
using System.Runtime.CompilerServices;

namespace DynamicInnerView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       
    }


    public class CustomEntry : Entry
    {

        public CustomEntry()
        {
            this.CustomEntryTextStyle = new CustomEntryStyle();
            
        }

        /// <summary>
        /// Gets or sets the style for hint label.
        /// </summary>
        public static readonly BindableProperty CustomTextStyleProperty =
            BindableProperty.Create(nameof(CustomEntryTextStyle), typeof(CustomEntryStyle), typeof(CustomEntry), null, BindingMode.TwoWay, null, propertyChanged: OnCustomTextColorPropertyChanged);

        private static void OnCustomTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is CustomEntry entry)
            {
                entry.TextColor = entry.CustomEntryTextStyle.TextColor;
            }
        }

       

        public CustomEntryStyle CustomEntryTextStyle
        {
            get { return (CustomEntryStyle)GetValue(CustomTextStyleProperty); }
            set { SetValue(CustomTextStyleProperty, value); }
        }
    }

}
