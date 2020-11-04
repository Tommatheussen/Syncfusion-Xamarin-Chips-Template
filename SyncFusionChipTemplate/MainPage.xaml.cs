using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SyncFusionChipTemplate
{
    public partial class MainPage : ContentPage
    {
        public ChipViewModel ViewModel;

        public MainPage()
        {
            BindingContext = ViewModel = new ChipViewModel();

            InitializeComponent();
        }
    }
}
