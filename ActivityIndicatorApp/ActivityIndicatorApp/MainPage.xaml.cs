using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActivityIndicatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);
            }

            Navigation.PushAsync(new NewPage());
        }
    }
}
