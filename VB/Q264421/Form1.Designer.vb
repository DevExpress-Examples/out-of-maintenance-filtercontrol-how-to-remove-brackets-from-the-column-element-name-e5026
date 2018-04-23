Imports Microsoft.VisualBasic
Imports System
Namespace Q264421
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
			Me.textEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.spinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.filterControl = New DXSample.MyFilterControl()
			CType(Me.textEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' persistentRepository1
			' 
			Me.persistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.textEdit, Me.spinEdit})
			' 
			' textEdit
			' 
			Me.textEdit.Name = "textEdit"
			' 
			' spinEdit
			' 
			Me.spinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit.Name = "spinEdit"
			' 
			' filterControl
			' 
			Me.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.filterControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.filterControl.Location = New System.Drawing.Point(0, 0)
			Me.filterControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.filterControl.Name = "filterControl"
			Me.filterControl.Size = New System.Drawing.Size(477, 366)
			Me.filterControl.TabIndex = 0
			Me.filterControl.Text = "myFilterControl1"
		   ' this.filterControl.CustomDrawFilterLabel += new DXSample.CustomDrawFilterLabelEventHandler(this.OnFilterControlCustomDrawFilterLabel);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(477, 366)
			Me.Controls.Add(Me.filterControl)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.textEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private filterControl As DXSample.MyFilterControl
		Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
		Private textEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private spinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

	End Class
End Namespace

