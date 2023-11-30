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
using Microsoft.Win32;

namespace WPFTutorial
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

		private void btnFire_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog fileDialog=new OpenFileDialog();
			fileDialog.Filter = "Image | *.webp";
			fileDialog.InitialDirectory = "C:\\Temp";
			fileDialog.Title = "Please pick Image files ...";
			fileDialog.Multiselect = true;
			bool? success=fileDialog.ShowDialog();
			if (success == true)
			{
				string path=fileDialog.FileName;
				string fileName=fileDialog.SafeFileName;
				tbInfo.Text = fileName;
			}

			else
			{
				//didnt pick anything
			}

		}
	}
}