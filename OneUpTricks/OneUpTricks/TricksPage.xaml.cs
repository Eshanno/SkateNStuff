using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OneUpTricks.Models;

namespace OneUpTricks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TricksPage : ContentPage
    {
        public IList<Trick> Tricks { get; private set; }

        public TricksPage()
        {
            InitializeComponent();
            
            Tricks = new List<Trick>();
            Tricks.Add(new Trick {
                Name ="Ollie",
                Desc ="Jump up and over obstacles" ,
                Image = "https://jclyel01.files.wordpress.com/2017/05/ollie.jpg?w=300&h=169",
                Steps = new Step[] { new Step { Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Number = 1 }, new Step { Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Number = 2 }, new Step { Details = "Ut luctus arcu arcu, id feugiat felis vehicula placerat. Mauris consectetur sit amet elit vitae.", Number = 3 } }

            });

            Tricks.Add(new Trick {
                Name = "Mannuel",
                Desc = "Riding with the front wheels up",
                Image = "https://www.johnsoncitypress.com/image/2018/11/08/x720_q60/DSC-0349-JPG-1.jpg",
                Steps = new Step[] { new Step { Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Number = 1 }, new Step { Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Number = 2 }, new Step { Details = "Ut luctus arcu arcu, id feugiat felis vehicula placerat. Mauris consectetur sit amet elit vitae.", Number = 3 } }
            });
            Tricks.Add(new Trick {
                Name = "Kickflip",
                Desc = "Lorem Ipsum Lorem Ipsum Lorem Ipsum",
                Image = "https://www.johnsoncitypress.com/image/2018/11/08/x720_q60/DSC-0349-JPG-1.jpg",
                Steps = new Step[] { new Step { Details="Lorem ipsum dolor sit amet, consectetur adipiscing elit", Number=1 }, new Step { Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Number = 2 }, new Step { Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", Number = 3 } }
            });

            BindingContext = this;
        }
        async void OnListViewItemSelected(Object Sender, SelectedItemChangedEventArgs e)
        {
            Trick selectedItem = e.SelectedItem as Trick;
            await Navigation.PushAsync(new TrickPage(selectedItem));
        }

        async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Trick tappedItem = e.Item as Trick;
        }
    }
}