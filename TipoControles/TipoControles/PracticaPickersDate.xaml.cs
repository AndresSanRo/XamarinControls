using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoControles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PracticaPickersDate : ContentPage
	{
        List<String> days;
        List<String> months;
        List<String> years;
        public PracticaPickersDate ()
		{
			InitializeComponent ();
            days = new List<String>();
            months = new List<String>();
            years = new List<String>();
            for (int i = 1; i <= 31; i++)
            {
                days.Add(i.ToString());
                this.pDay.Items.Add(i.ToString());
            }
            for (int j = 1; j <= 12; j++)
            {
                months.Add(j.ToString());
                this.pMonth.Items.Add(j.ToString());
            }
            for (int k = 1995; k <= 2020; k++)
            {
                years.Add(k.ToString());
                this.pYear.Items.Add(k.ToString());
            }
            this.btnCalcDate.Clicked += BtnCalcDate_Clicked;
        }

        private void BtnCalcDate_Clicked(object sender, EventArgs e)
        {
            int dayIndex = this.pDay.SelectedIndex;
            int monthIndex = this.pMonth.SelectedIndex;
            int yearIndex = this.pYear.SelectedIndex;
            if (dayIndex != -1 && monthIndex != -1 && yearIndex != -1)
            {
                //CultureInfo myCultureInfo = new CultureInfo("es-ES");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                String dateString = days[dayIndex].ToString() + "/" 
                                    + months[monthIndex].ToString() + "/" 
                                    + years[yearIndex].ToString();
                DateTime nameDay = DateTime.Parse(dateString);
                this.lblDayName.Text = "Día: " + nameDay.ToString("dddd");
            }
        }
    }
}