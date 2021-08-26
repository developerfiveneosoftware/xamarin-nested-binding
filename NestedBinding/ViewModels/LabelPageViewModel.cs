using NestedBinding.Control;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NestedBinding.ViewModels
{
    public class LabelPageViewModel : BaseViewModel
    {
        public ObservableCollection<CustomButtonGridView> GridViewList { get; set; }

        public CustomButtonGridView selectedView;
        public CustomButtonGridView SelectedView
        {
            get { return selectedView; }
            set
            {
                if(selectedView != value)
                {
                    selectedView = value;
                    OnPropertyChanged();
                }
            }
        }

        Color backgroundColor;
        public Color BackgroundColor
        {
            get
            {
                return  backgroundColor; 
            }
            set
            {
                if(backgroundColor!= value)
                {
                    backgroundColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public LabelPageViewModel()
        {

        }

        public void InitiliseGridContent()
        {
            GridViewList = new ObservableCollection<CustomButtonGridView>();

            //Loop through and create blank items.
            for (int i = 0; i < 16; i++)
            {
                GridViewList.Add(new CustomButtonGridView(this));
            }

            SelectedView = GridViewList[0];
        }


        public ICommand BtnCmd
        {
            get { return new Command<CustomButtonGridView>(async (x) => await ButtonClicked(x)); }
        }

        async Task ButtonClicked(CustomButtonGridView model)
        {
            SelectedView = model;

            foreach(var item in GridViewList)
            {
                if(item != SelectedView)
                {
                    BackgroundColor = Color.Red;
                }
                else
                {
                    BackgroundColor = Color.Blue;
                }
                
            }
        }
    }
}
