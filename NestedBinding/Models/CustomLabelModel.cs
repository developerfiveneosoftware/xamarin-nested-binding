using NestedBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestedBinding.Models
{
    public class CustomLabelModel : BaseViewModel
    {
        string label;

        public string Label
        {
            get { return label; }
            set
            {
                if (label != value)
                {
                    label = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
