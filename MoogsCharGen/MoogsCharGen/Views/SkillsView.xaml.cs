using Engine.Skills;
using MoogsCharGen.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoogsCharGen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsView : ContentPage
    {
        public SkillsView()
        {
            InitializeComponent();
            BindingContext = new InfoViewModel(SkillGrid);
            BackgroundImageSource = ImageSource.FromFile("Resources/drawable/page1.jpg");
        }

    }
}