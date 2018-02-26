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
	public partial class Details : ContentPage
	{
        public user account;
        public String name;
		public Details (int id)
		{
            this.account = user.getUser(id);
            BindingContext = account;
            Console.WriteLine(account.name);
			InitializeComponent ();
            DisplayAlert("user", account.name, "ok");
		}
	}
}