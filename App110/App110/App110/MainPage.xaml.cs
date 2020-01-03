using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App110
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ExampleViewModel vm = new ExampleViewModel();
            vm.Message = "test";
            BindingContext = vm;
        }
    }

    public class ExampleViewModel : INotifyPropertyChanged
    {
        private string _message;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Message
        {
            set
            {
                if (_message != value)
                {
                    _message = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Message"));
                    }
                }
            }
            get
            {
                return _message;
            }
        }

        public ExampleViewModel()
        {
            Message = "Message from viewModel!";
        }
    }
}
