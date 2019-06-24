using EsqueletoSQLite.Models;
using EsqueletoSQLite.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EsqueletoSQLite.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FriendView : ContentPage
	{
        private Friend friend;

        public FriendView (Friend friend = null)
		{
			InitializeComponent ();
            if (friend == null)
            {
                BindingContext = new FriendViewViewModel(Navigation);
            }
            else
            {
                BindingContext = new FriendViewViewModel(Navigation, friend);
            }
        }
	}
}