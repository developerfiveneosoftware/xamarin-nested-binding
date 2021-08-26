using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NestedBinding.ViewModels
{
    public class ButtonGridViewModel : BaseViewModel
    {

        public ICommand BtnCmd
        {
            get { return new Command(async () => await ButtonClicked()); }
        }

        async Task ButtonClicked()
        {
            Application.Current.MainPage.DisplayAlert("Clicked", "Clicked", "OK");
        }

        public Color selectedColor;
        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                if(selectedColor != value)
                {
                    selectedColor = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
