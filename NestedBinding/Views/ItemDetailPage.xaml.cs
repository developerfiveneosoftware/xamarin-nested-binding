using NestedBinding.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NestedBinding.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}