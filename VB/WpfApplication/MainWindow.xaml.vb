Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid

Namespace WpfApplication
	'' <summary>
	'' Interaction logic for MainWindow.xaml
	'' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private _Adapter As NorthwindDataSetTableAdapters.CustomersTableAdapter = New NorthwindDataSetTableAdapters.CustomersTableAdapter()

		Private _Table As NorthwindDataSet.CustomersDataTable
		Public Sub New()
			InitializeComponent()
			_Table = _Adapter.GetData()
			gridControl1.ItemsSource = _Table


		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			_Adapter.Update(_Table)
		End Sub
	End Class
End Namespace
