using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ConverterSamples.Resources;

namespace ConverterSamples
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void boolToVisButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BooleanToVisibilityConverterPage.xaml", UriKind.Relative));
        }

        private void intToBrushButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/IntToBrushConverterPage.xaml", UriKind.Relative));
        }

        private void objToResourceButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ObjToStringResourcePage.xaml", UriKind.Relative));
        }

        private void stringToImageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/StringToImagePage.xaml", UriKind.Relative));
        }
    }
}