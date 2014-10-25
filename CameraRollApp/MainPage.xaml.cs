using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace CameraRollApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            Loaded += MainPage_Loaded;
        }

        async void  MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var last = (await KnownFolders.CameraRoll.GetFilesAsync()).Reverse();
            /*int c = 0;
            foreach (var storageFile in last)
            {
                Debug.WriteLine(storageFile.Name);
                if (storageFile.ContentType != "image/jpeg") break;
                c ++;
                if (c == 15)
                {
                    int xl = 0;
                    break;
                };
                try
                {
                    Image img = new Image();
                
                var bitmap = new BitmapImage();
                bitmap.SetSource(await storageFile.OpenReadAsync());

                img.Source = bitmap;
                root.Children.Add(img);
            }
            catch(Exception ex){}
        }*/


            var bitmap1 = new BitmapImage();
            bitmap1.SetSource(await last.ElementAt(0).OpenReadAsync());
            f1.Image = bitmap1;
            var bitmap2 = new BitmapImage();
            bitmap2.SetSource(await last.ElementAt(1).OpenReadAsync());
            f2.Image = bitmap2;
            var bitmap3 = new BitmapImage();
            bitmap3.SetSource(await last.ElementAt(2).OpenReadAsync());
            f3.Image = bitmap3;

            var bitmap4 = new BitmapImage();
            bitmap4.SetSource(await last.ElementAt(3).OpenReadAsync());
            
            var stack = new List<ImageFrame>{f1,f2,f3};
            Tapped += (a, b) =>
            {

            };

            
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }
    }
}
