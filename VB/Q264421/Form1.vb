Imports Microsoft.VisualBasic
Imports System
Imports DXSample
Imports System.Linq
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Data.Filtering.Helpers

Namespace Q264421
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim columns As New FilterColumnCollection()
			columns.Add(New UnboundFilterColumn("Order ID", "OrderID", GetType(Integer), spinEdit, FilterColumnClauseClass.Generic))
			columns.Add(New UnboundFilterColumn("Product", "Product", GetType(String), textEdit, FilterColumnClauseClass.String))
			columns.Add(New UnboundFilterColumn("Discount", "Discount", GetType(Decimal), spinEdit, FilterColumnClauseClass.Generic))
			filterControl.SetFilterColumnsCollection(columns)
			filterControl.FilterCriteria = CriteriaOperator.Parse("Product between ('Alice Munton', 'Icura') && Discount > .05")
			filterControl.SetDefaultColumn(filterControl.FilterColumns("OrderID"))
		End Sub
	End Class
End Namespace
