Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Filtering

Namespace DXSample
	Public Class MyFilterControl
		Inherits FilterControl
		Protected Overrides Function CreateModel() As WinFilterTreeNodeModel
			Return New MyWinFilterTreeNodeModel(Me)
		End Function
	End Class

	Public Class MyFilterControlLabelInfo
		Inherits FilterControlLabelInfo
		Public Sub New(ByVal node As Node)
			MyBase.New(node)
		End Sub

		Public Overrides Sub Paint(ByVal info As ControlGraphicsInfoArgs)
			ViewInfo.Calculate(info.Graphics)
			ViewInfo.TopLine = 0
			For i As Integer = 0 To ViewInfo.Count - 1
				Dim textViewInfo As FilterLabelInfoTextViewInfo = CType(ViewInfo(i), FilterLabelInfoTextViewInfo)
				Dim nodeElement As NodeEditableElement = TryCast(textViewInfo.InfoText.Tag, NodeEditableElement)
                Dim _elementType As ElementType = If(Nothing Is nodeElement, ElementType.None, nodeElement.ElementType)
                If _elementType = ElementType.Property Then
                    textViewInfo.InfoText.Text = textViewInfo.InfoText.Text.Trim("["c, "]"c)
                End If
				ViewInfo.Calculate(info.Graphics)
				ViewInfo(i).Draw(info.Cache, info.ViewInfo.Appearance.GetFont(), ViewInfo(i).InfoText.Color, info.ViewInfo.Appearance.GetStringFormat())
			Next i
		End Sub

	End Class

	Public Class MyWinFilterTreeNodeModel
		Inherits WinFilterTreeNodeModel
		Public Sub New(ByVal control As FilterControl)
			MyBase.New(control)
		End Sub

        Public Overrides Sub OnVisualChange(ByVal _action As FilterChangedActionInternal, ByVal node As Node)
            If _action = FilterChangedActionInternal.NodeAdded Then
                CType(GetType(WinFilterTreeNodeModel).GetField("labels", BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(Me), Dictionary(Of Node, FilterControlLabelInfo))(node) = New MyFilterControlLabelInfo(node)
            ElseIf _action = FilterChangedActionInternal.RootNodeReplaced Then
                Dim labels As Dictionary(Of Node, FilterControlLabelInfo) = CType(GetType(WinFilterTreeNodeModel).GetField("labels", BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(Me), Dictionary(Of Node, FilterControlLabelInfo))
                labels.Clear()
                RecursiveVisitor(RootNode, Function(child)
                                               Dim info As New MyFilterControlLabelInfo(child)
                                               info.Clear()
                                               info.CreateLabelInfoTexts()
                                               labels(child) = info
                                               Return New Object()
                                           End Function)
            Else
                MyBase.OnVisualChange(_action, node)
            End If
        End Sub
	End Class
End Namespace