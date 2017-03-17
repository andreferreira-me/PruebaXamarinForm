using PruebaXamarinForm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PruebaXamarinForm.View
{
    public partial class FormsAssistControlPage : ContentPage
    {
        public FormsAssistControlPage()
        {
            InitializeComponent();
            this.BindingContext = new StudentDirectoryVM();
        }
    }
}
