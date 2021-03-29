using RaindropFunctions;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace RaindropsWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			BackgroundImage.ImageSource = new BitmapImage(BackgroundSetter.Background(""));
		}

		private void RainButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				PPPTextBox.Text = Raindrops.PPP(Int32.Parse(TextBoxInput.Text));
				BackgroundImage.ImageSource = new BitmapImage(BackgroundSetter.Background(PPPTextBox.Text));
				ExplanationTextBox.Text = Explanation.Reasoning(Int32.Parse(TextBoxInput.Text));
			}
			catch (Exception)
			{
				PPPTextBox.Text = "Please enter an integer!";
			}
		}
	}
}