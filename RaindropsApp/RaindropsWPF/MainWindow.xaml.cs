using RaindropFunctions;
using System;
using System.Windows;

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
		}

		private void RainButton_Click(object sender, RoutedEventArgs e)
		{
			PPPTextBox.Text = Raindrops.PPP(Int32.Parse(TextBoxInput.Text));
			ExplanationTextBox.Text = Explanation.Reasoning(Int32.Parse(TextBoxInput.Text));
		}
	}
}