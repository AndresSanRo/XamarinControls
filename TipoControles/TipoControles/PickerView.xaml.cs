using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoControles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerView : ContentPage
	{
        List<String> ingredients;
		public PickerView ()
		{
			InitializeComponent ();
            ingredients = new List<string>()
            { "Leche", "Cacao", "Avellanas", "Azucar"};
            foreach (String i in ingredients)
            {
                this.picker1.Items.Add(i);
            }
            this.picker1.SelectedIndexChanged += (sender, args) =>
            {
                int index = this.picker1.SelectedIndex;
                if (index == -1)
                    this.lblPicker.Text = "Selecciona un ingrediente";
                else
                    this.lblPicker.Text = "Ingrediente seleccionado: " + this.ingredients[index];
            };
		}
	}
}