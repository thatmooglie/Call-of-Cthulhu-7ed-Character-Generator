using Engine.Character;
using MoogsCharGen.ViewModel;
using Xamarin.Forms;

namespace MoogsCharGen
{
    public partial class MainPage : TabbedPage
    {
        private InfoViewModel infoViewModel = new InfoViewModel();
        public InfoViewModel InfoViewModel
        {
            get { return infoViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
