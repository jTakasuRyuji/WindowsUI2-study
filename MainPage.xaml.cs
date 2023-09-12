using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MUXC = Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace WindowsUI2_study
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<MyDataItem> MyData { get; set; } = new ObservableCollection<MyDataItem>();

        public MainPage()
        {
            this.InitializeComponent();
            for (int i = 1; i < 50; i++)
            {
            MyData.Add(new MyDataItem { ButtonText = $"ボタン{i}" });
            }
            // ... 他のデータを追加

            //myItemsRepeater.ItemsSource = MyData;
            for (int i = 0; i < 80; i++)
            {
                Button button = new Button();
                button.Content = $"ボタン {i + 1}";
                button.Tag = i;
                button.Width = 120;
                button.Height = 60;
                myWrapGrid.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class MyDataItem
    {
        public string ButtonText { get; set; }
    }
}
