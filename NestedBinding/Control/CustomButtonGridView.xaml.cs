using NestedBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NestedBinding.Control
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButtonGridView : ContentView
    {
        ButtonGridViewModel VM { get; set; }


        LabelPageViewModel labelVM { get; set; }

        public CustomButtonGridView(LabelPageViewModel vm)
        {
            InitializeComponent();
            labelVM = vm;
            BindingContext = labelVM;

            grid.RowDefinitions = new RowDefinitionCollection();
            
            grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
        }

        public static readonly BindableProperty SelectedCommandProperty =
       BindableProperty.Create(nameof(SelectCmd), typeof(ICommand), typeof(CustomButtonGridView), null);

        public ICommand SelectCmd
        {
            get => (ICommand)GetValue(SelectedCommandProperty);
            set
            {
                SetValue(SelectedCommandProperty, value);
                labelVM.selectedView = this;

            }
        }

        public static void Execute(ICommand command)
        {
            if (command == null) return;
            if (command.CanExecute(null))
            {
                command.Execute(null);
            }
        }

        // this is the command that gets bound by the control in the view
        // (ie. a Button, TapRecognizer, or MR.Gestures)
        public Command OnTap => new Command(() => Execute(SelectCmd));
    }
}