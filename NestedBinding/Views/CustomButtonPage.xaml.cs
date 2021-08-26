using NestedBinding.Control;
using NestedBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NestedBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelPage : ContentPage
    {
        LabelPageViewModel VM { get; set; }
        public LabelPage()
        {
            InitializeComponent();
            VM = new LabelPageViewModel();
            VM.InitiliseGridContent();
            BindingContext = VM;

            grid.RowDefinitions = new RowDefinitionCollection();
            for(int i = 0; i < 5; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
            }

            grid.ColumnDefinitions = new ColumnDefinitionCollection();
            for (int i = 0; i < 5; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
            }

            int listValue = 0;

            for(int i = 0;i <4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    grid.Children.Add(VM.GridViewList[listValue],j,i);
                    listValue = listValue + 1;
                }
            }
        }
    }
}