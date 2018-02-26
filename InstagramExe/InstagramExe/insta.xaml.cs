using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramExe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class insta : ContentPage
	{
        

        public insta ()
		{
			InitializeComponent ();
            list.ItemsSource = user.getUser();
		}

        async void moveToDetails(Object sender ,ItemTappedEventArgs e)
        {
            var account = e.Item as user;
            await Navigation.PushAsync(new Details(account.id));
        }


    }
}