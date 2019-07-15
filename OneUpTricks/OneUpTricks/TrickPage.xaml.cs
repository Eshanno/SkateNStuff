using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneUpTricks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OneUpTricks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrickPage : ContentPage
    {
        public Trick Trick { get; set; }
        public IList<Step> Stepz { get; private set; }

        public string Something { get; set; }
        
        public TrickPage(Trick trick)
        {
            InitializeComponent();

            Trick = trick;
            Stepz = new List<Step>();
            foreach(Step step in Trick.Steps)
            {
                Stepz.Add(step);
            }
            


            BindingContext = this;
        }
    }
}