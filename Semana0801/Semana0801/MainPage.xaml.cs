using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana0801
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += Item1_Clicked;
            Item2.Clicked += Item2_Clicked;
            Item3.Clicked += Item3_Clicked;
            Item4.Clicked += Item4_Clicked;
            Item5.Clicked += Item5_Clicked;
            
        }

        private void Item5_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item4_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item3_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item2_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item1_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
