Namespace WindowsApplication1
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(4)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(678, 436)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.gridView2})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2, Me.gridBand3, Me.gridBand4, Me.gridBand5, Me.gridBand6, Me.gridBand7, Me.gridBand8})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.bandedGridColumn1, Me.bandedGridColumn2, Me.bandedGridColumn3, Me.bandedGridColumn4, Me.bandedGridColumn5, Me.bandedGridColumn6, Me.bandedGridColumn7, Me.bandedGridColumn8, Me.bandedGridColumn9, Me.bandedGridColumn10, Me.bandedGridColumn11})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Columns.Add(Me.bandedGridColumn1)
			Me.gridBand1.Columns.Add(Me.bandedGridColumn7)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 75
			' 
			' bandedGridColumn1
			' 
			Me.bandedGridColumn1.Caption = "bandedGridColumn1"
			Me.bandedGridColumn1.FieldName = "Name"
			Me.bandedGridColumn1.Name = "bandedGridColumn1"
			Me.bandedGridColumn1.Visible = True
			' 
			' bandedGridColumn7
			' 
			Me.bandedGridColumn7.Caption = "bandedGridColumn7"
			Me.bandedGridColumn7.FieldName = "Name"
			Me.bandedGridColumn7.Name = "bandedGridColumn7"
			Me.bandedGridColumn7.RowIndex = 1
			Me.bandedGridColumn7.Visible = True
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "gridBand2"
			Me.gridBand2.Columns.Add(Me.bandedGridColumn4)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn5)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn8)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 150
			' 
			' bandedGridColumn4
			' 
			Me.bandedGridColumn4.Caption = "bandedGridColumn4"
			Me.bandedGridColumn4.FieldName = "Name"
			Me.bandedGridColumn4.Name = "bandedGridColumn4"
			Me.bandedGridColumn4.Visible = True
			' 
			' bandedGridColumn5
			' 
			Me.bandedGridColumn5.Caption = "bandedGridColumn5"
			Me.bandedGridColumn5.FieldName = "Name"
			Me.bandedGridColumn5.Name = "bandedGridColumn5"
			Me.bandedGridColumn5.Visible = True
			' 
			' bandedGridColumn8
			' 
			Me.bandedGridColumn8.Caption = "bandedGridColumn8"
			Me.bandedGridColumn8.FieldName = "Name"
			Me.bandedGridColumn8.Name = "bandedGridColumn8"
			Me.bandedGridColumn8.RowIndex = 1
			Me.bandedGridColumn8.Visible = True
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "gridBand3"
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Visible = False
			Me.gridBand3.Width = 75
			' 
			' gridBand4
			' 
			Me.gridBand4.Caption = "gridBand4"
			Me.gridBand4.Columns.Add(Me.bandedGridColumn10)
			Me.gridBand4.Columns.Add(Me.bandedGridColumn9)
			Me.gridBand4.Columns.Add(Me.bandedGridColumn3)
			Me.gridBand4.Columns.Add(Me.bandedGridColumn11)
			Me.gridBand4.Name = "gridBand4"
			Me.gridBand4.Width = 225
			' 
			' bandedGridColumn10
			' 
			Me.bandedGridColumn10.Caption = "bandedGridColumn10"
			Me.bandedGridColumn10.FieldName = "Name"
			Me.bandedGridColumn10.Name = "bandedGridColumn10"
			Me.bandedGridColumn10.Visible = True
			' 
			' bandedGridColumn9
			' 
			Me.bandedGridColumn9.Caption = "bandedGridColumn9"
			Me.bandedGridColumn9.FieldName = "Name"
			Me.bandedGridColumn9.Name = "bandedGridColumn9"
			Me.bandedGridColumn9.Visible = True
			' 
			' bandedGridColumn3
			' 
			Me.bandedGridColumn3.Caption = "bandedGridColumn3"
			Me.bandedGridColumn3.FieldName = "Name"
			Me.bandedGridColumn3.Name = "bandedGridColumn3"
			Me.bandedGridColumn3.Visible = True
			' 
			' bandedGridColumn11
			' 
			Me.bandedGridColumn11.Caption = "bandedGridColumn11"
			Me.bandedGridColumn11.FieldName = "Name"
			Me.bandedGridColumn11.Name = "bandedGridColumn11"
			Me.bandedGridColumn11.RowIndex = 1
			Me.bandedGridColumn11.Visible = True
			' 
			' gridBand5
			' 
			Me.gridBand5.Caption = "gridBand5"
			Me.gridBand5.Columns.Add(Me.bandedGridColumn6)
			Me.gridBand5.Name = "gridBand5"
			Me.gridBand5.Visible = False
			Me.gridBand5.Width = 75
			' 
			' bandedGridColumn6
			' 
			Me.bandedGridColumn6.Caption = "bandedGridColumn6"
			Me.bandedGridColumn6.FieldName = "Name"
			Me.bandedGridColumn6.Name = "bandedGridColumn6"
			Me.bandedGridColumn6.Visible = True
			' 
			' gridBand6
			' 
			Me.gridBand6.Caption = "gridBand6"
			Me.gridBand6.Columns.Add(Me.bandedGridColumn2)
			Me.gridBand6.Name = "gridBand6"
			Me.gridBand6.Visible = False
			Me.gridBand6.Width = 75
			' 
			' bandedGridColumn2
			' 
			Me.bandedGridColumn2.Caption = "bandedGridColumn2"
			Me.bandedGridColumn2.FieldName = "Name"
			Me.bandedGridColumn2.Name = "bandedGridColumn2"
			Me.bandedGridColumn2.Visible = True
			' 
			' gridBand7
			' 
			Me.gridBand7.Caption = "gridBand7"
			Me.gridBand7.Name = "gridBand7"
			Me.gridBand7.Visible = False
			' 
			' gridBand8
			' 
			Me.gridBand8.Caption = "gridBand8"
			Me.gridBand8.Name = "gridBand8"
			Me.gridBand8.Visible = False
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(678, 436)
			Me.Controls.Add(Me.gridControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private bandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	End Class
End Namespace

