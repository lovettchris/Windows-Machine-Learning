using Microsoft.AI.MachineLearning;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Media;
using Windows.Storage;
using WinMLSamplesGalleryNative;

namespace WinMLSamplesGallery.Samples
{

    public sealed partial class AdapterSelection : Page
    {
        public AdapterSelection()
        {
            this.InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Initialized Adapter Selection");

            List<string> adapter_options = new List<string> {
                "CPU",
                "DirectX",
                "DirectXHighPerformance",
                "DirectXMinPower"
            };

            var string_arr = WinMLSamplesGalleryNative.AdapterList.GetAdapters();
            var some_strings = new List<string>(string_arr);
            System.Diagnostics.Debug.WriteLine("Num Elements {0}", some_strings.Count);
            for(int i = 0; i < some_strings.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(some_strings[i]);
            }

            adapter_options.AddRange(some_strings);
            AdapterListView.ItemsSource = adapter_options;


            //System.Diagnostics.Debug.WriteLine("Called GetAdapters");
            //System.Diagnostics.Debug.WriteLine(some_str);
        }

        private void ChangeAdapter(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Changed selection {0}", AdapterListView.SelectedIndex);
        }
    }
}
