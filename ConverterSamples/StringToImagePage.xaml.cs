using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ConverterSamples
{
    public partial class StringToImagePage : PhoneApplicationPage
    {
        public StringToImagePage()
        {
            this.DataContext = new Models.StringToImageViewModel();
            InitializeComponent();
        }
    }
}