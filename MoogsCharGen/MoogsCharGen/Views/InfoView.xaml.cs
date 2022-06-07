using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MoogsCharGen.ViewModel;
using Engine.Character;

namespace MoogsCharGen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoView : ContentPage
    {
        private static InfoViewModel viewModel;
        public static InfoViewModel InfoViewModel
        {
            get { return viewModel; }
        }
        public InfoView()
        {
            InitializeComponent();
            viewModel = new InfoViewModel(SkillGrid);
            BindingContext = viewModel;
            BackgroundImageSource = ImageSource.FromFile("Resources/drawable/page1.jpg");    
        }
    }
}