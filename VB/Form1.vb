Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i) })
			Next i
			Return tbl
				End Function


		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			AddHandler gridControl1.PaintEx, AddressOf GridControl1_PaintEx
		End Sub

		Private Sub GridControl1_PaintEx(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.PaintExEventArgs)
			For Each band As GridBand In advBandedGridView1.Bands
				DrawObjectBorder(e.Cache, GetBandBounds(band))
			Next band
			For Each col As GridColumn In advBandedGridView1.VisibleColumns
				DrawObjectBorder(e.Cache, GetColumnBounds(col))
			Next col
		End Sub

		Private Sub DrawObjectBorder(ByVal g As GraphicsCache, ByVal bounds As Rectangle)
			g.DrawRectangle(New Pen(Brushes.Black, 2), bounds)
		End Sub

		Public ReadOnly Property ViewInfo() As BandedGridViewInfo
			Get
				Return TryCast(advBandedGridView1.GetViewInfo(), BandedGridViewInfo)
			End Get
		End Property

		Private Function GetBandBounds(ByVal band As GridBand) As Rectangle
			Dim info As HeaderObjectInfoArgs = ViewInfo.BandsInfo(band)
			Return If(info Is Nothing, Rectangle.Empty, info.Bounds)
		End Function
		Private Function GetColumnBounds(ByVal col As GridColumn) As Rectangle
			Dim info As HeaderObjectInfoArgs = ViewInfo.ColumnsInfo(col)
			Return If(info Is Nothing, Rectangle.Empty, info.Bounds)
		End Function

	End Class
End Namespace