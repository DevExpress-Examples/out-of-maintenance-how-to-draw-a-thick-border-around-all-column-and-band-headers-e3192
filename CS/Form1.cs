using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i) });
            return tbl;
        }
        

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            gridControl1.PaintEx += GridControl1_PaintEx;
        }

        private void GridControl1_PaintEx(object sender, DevExpress.XtraGrid.PaintExEventArgs e)
        {
            foreach (GridBand band in advBandedGridView1.Bands)
            {
                DrawObjectBorder(e.Cache, GetBandBounds(band));
            }
            foreach (GridColumn col in advBandedGridView1.VisibleColumns)
            {
                DrawObjectBorder(e.Cache, GetColumnBounds(col));
            }
        }
        
        private void DrawObjectBorder(GraphicsCache g, Rectangle bounds)
        {
            g.DrawRectangle(new Pen(Brushes.Black, 2), bounds);
        }

        public BandedGridViewInfo ViewInfo
        {
            get
            {
                return advBandedGridView1.GetViewInfo() as BandedGridViewInfo;
            }
        }

        private Rectangle GetBandBounds(GridBand band)
        {
            HeaderObjectInfoArgs info = ViewInfo.BandsInfo[band];
            return info == null? Rectangle.Empty : info.Bounds;
        }
        private Rectangle GetColumnBounds(GridColumn col)
        {
            HeaderObjectInfoArgs info = ViewInfo.ColumnsInfo[col];
            return info == null ? Rectangle.Empty : info.Bounds;
        }

    }
}