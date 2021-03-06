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
			// sets the initial background
			BackgroundImage.ImageSource = new BitmapImage(BackgroundSetter.Background(""));
		}

		private void RainButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				/// prints the output (plingplangplong) into the text box
				PPPTextBox.Text = Raindrops.PlingPlangPlong(Int32.Parse(TextBoxInput.Text));

				// changes the background depending on the output
				BackgroundImage.ImageSource = new BitmapImage(BackgroundSetter.Background(PPPTextBox.Text));

				// generates the explanation.
				ExplanationTextBox.Text = Explanation.Reasoning(Int32.Parse(TextBoxInput.Text));
			}
			catch (Exception)
			{
				PPPTextBox.Text = "Please enter an integer!";
			}
		}
	}
}