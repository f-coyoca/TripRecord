using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TripsRecord
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void LoginButton_Clicked(Object sender, EventArgs e)
        {
            bool isEmeilEmpy = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEntry = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmeilEmpy || isPasswordEntry)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }

    }
}
