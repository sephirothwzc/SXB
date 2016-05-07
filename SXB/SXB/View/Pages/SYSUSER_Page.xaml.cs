using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SXB.View.Pages
{
    [Navigation.RegisterViewModel(typeof(SXB.ViewModel.Pages.SYS_USER_PageModel))]
    public partial class SYSUSER_Page : ContentPage
    { 
        public SYSUSER_Page()
        {
            InitializeComponent();
        }

    }
}
