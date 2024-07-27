using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeySplash.HelperWindows;

namespace screenMeasure;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnMeasure_OnClick(object sender, RoutedEventArgs e)
    {
        PlacementWindow measurer = new(200, 200);
        measurer.ShowDialog();
        tbkHeight.Text = measurer.Height.ToString() + "x";
        tbkWidth.Text = measurer.Width.ToString() + "px";
    }
}