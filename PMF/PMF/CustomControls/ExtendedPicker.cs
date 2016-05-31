using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.CustomControls
{
    public class ExtendedPicker : Picker
    {
        public static readonly BindableProperty ItemsSourceProperty =
                BindableProperty.Create(propertyName: "ItemsSource", declaringType: typeof(List<string>), returnType: typeof(List<string>), propertyChanged: (bindable, oldValue, newValue) =>
                {
                    var picker = (ExtendedPicker) bindable;
                    picker.Items.Clear();
                    foreach (var i in (List<string>) newValue)
                        picker.Items.Add(i);
                });

        public List<string> ItemsSource
        {
            get { return (List<string>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

    }
}
