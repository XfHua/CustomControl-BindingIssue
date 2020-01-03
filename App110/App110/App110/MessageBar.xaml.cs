using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App110
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageBar : ContentView
    {
        public static readonly BindableProperty MessageTextProperty = BindableProperty.Create(
            propertyName: nameof(MessageText),
            returnType: typeof(string),
            declaringType: typeof(MessageBar),
            defaultValue: default(string));

        public string MessageText
        {
            get { return (string)GetValue(MessageTextProperty); }
            set { SetValue(MessageTextProperty, value); }
        }

        public MessageBar()
        {
            InitializeComponent();
        }
    }
}