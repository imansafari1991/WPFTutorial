using System.Collections;
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

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{

			if(!string.IsNullOrWhiteSpace(txtEntry.Text))
			{
				lvEntries.Items.Add(txtEntry.Text);
				txtEntry.Clear();
			}
		}
		private void btnAdd_mouseEnter(object sender, RoutedEventArgs e)
		{
			btnAdd.FontWeight = FontWeights.Bold;
		}
		private void btnAdd_mouseLeave(object sender, RoutedEventArgs e)
		{
			btnAdd.FontWeight = FontWeights.Medium;
		}

		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			int index = lvEntries.SelectedIndex;
			//object item = lvEntries.SelectedItem;
			//var result = MessageBox.Show($"Are you sure you want to delete:{(string)item}?", "Sure?",
			//	MessageBoxButton.YesNo);
			//if (result == MessageBoxResult.Yes)
			//{
			//	lvEntries.Items.Remove(item);
			//}
			
			var items = lvEntries.SelectedItems;
			var result = MessageBox.Show($"Are you sure you want to delete:{items.Count}?", "Sure?",
				MessageBoxButton.YesNo);
			if (result == MessageBoxResult.Yes)
			{
				var itemsList = new ArrayList(items);
				foreach (var item in itemsList)
				{
					lvEntries.Items.Remove(item);
				}

				
			}

		}
	}
}