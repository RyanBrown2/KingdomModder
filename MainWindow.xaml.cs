using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace KingdomModder
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		FileHandler fileHandler;

		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainViewModel();

			fileHandler = new FileHandler();
		}
		private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void OpenFile(object sender, ExecutedRoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == true)
			{
				fileHandler.openFile(dialog.FileName);
				SetFileOpenStatus(true);

			}
		}

		private void SetFileOpenStatus(bool visible)
		{
            if (DataContext is MainViewModel viewModel)
            {
                // Update the IsVisible property in the view model
                viewModel.IsFileOpen = visible;
            }
        }

	}


}
