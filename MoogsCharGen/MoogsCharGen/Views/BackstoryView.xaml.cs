using Engine.Character;
using MoogsCharGen.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoogsCharGen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BackstoryView : ContentPage
    {
        public BackstoryView()
        {
            InitializeComponent();
            BindingContext = new BackstoryViewModel();
            BackgroundImageSource = ImageSource.FromFile("Resources/drawable/page1.jpg");
        }
    }
}