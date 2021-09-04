using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (sender is Button btn&& e.LeftButton==MouseButtonState.Pressed)
			{
				btn.Background = new SolidColorBrush(Color.FromRgb((byte)Rand.Next(255), (byte)Rand.Next(255), (byte)Rand.Next(255)));
				MessageBox.Show($"{btn.Content} Button Clicked","Information",MessageBoxButton.OK,MessageBoxImage.Information);
			}
			else if (sender is Button btn2 && e.RightButton == MouseButtonState.Pressed)
			{
				grid.Children.Remove(btn2);
				Window.Title += $"{btn2.Content} ";
			}
		}
		public Random Rand { get; set; } = new Random();
		private void Button_Loaded(object sender, RoutedEventArgs e)
		{
			if (sender is Button btn) 
				btn.Background = new SolidColorBrush(Color.FromRgb((byte)Rand.Next(255), (byte)Rand.Next(255), (byte)Rand.Next(255)));
		}

	}
}
