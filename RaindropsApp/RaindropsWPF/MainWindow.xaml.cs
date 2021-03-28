﻿using System;
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
using RaindropFunctions;

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
			PPPTextBox.Text = Raindrops.PlingPlangPlong(Int32.Parse(TextBoxInput.Text));

			var uri = new Uri("backgrounds/nice.jpg", UriKind.Relative);
			BackgroundImage.ImageSource = new BitmapImage(uri);

		}
	}
}
