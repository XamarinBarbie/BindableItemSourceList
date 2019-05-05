using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindableItemSourceList
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TitleAndValueCellList : ContentView
	{
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(
                nameof(ItemsSource), typeof(IEnumerable), typeof(TitleAndValueCellList));

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public TitleAndValueCellList ()
		{
			InitializeComponent ();
		}
	}
}