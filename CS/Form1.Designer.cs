namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(678, 436);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.gridView2});
            this.gridControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.gridControl1_Paint);
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6,
            this.gridBand7,
            this.gridBand8});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8,
            this.bandedGridColumn9,
            this.bandedGridColumn10,
            this.bandedGridColumn11});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn7);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 75;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "bandedGridColumn1";
            this.bandedGridColumn1.FieldName = "Name";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.Caption = "bandedGridColumn7";
            this.bandedGridColumn7.FieldName = "Name";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.RowIndex = 1;
            this.bandedGridColumn7.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Columns.Add(this.bandedGridColumn4);
            this.gridBand2.Columns.Add(this.bandedGridColumn5);
            this.gridBand2.Columns.Add(this.bandedGridColumn8);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 150;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "bandedGridColumn4";
            this.bandedGridColumn4.FieldName = "Name";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "bandedGridColumn5";
            this.bandedGridColumn5.FieldName = "Name";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.Caption = "bandedGridColumn8";
            this.bandedGridColumn8.FieldName = "Name";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.RowIndex = 1;
            this.bandedGridColumn8.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "gridBand3";
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Visible = false;
            this.gridBand3.Width = 75;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "gridBand4";
            this.gridBand4.Columns.Add(this.bandedGridColumn10);
            this.gridBand4.Columns.Add(this.bandedGridColumn9);
            this.gridBand4.Columns.Add(this.bandedGridColumn3);
            this.gridBand4.Columns.Add(this.bandedGridColumn11);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 225;
            // 
            // bandedGridColumn10
            // 
            this.bandedGridColumn10.Caption = "bandedGridColumn10";
            this.bandedGridColumn10.FieldName = "Name";
            this.bandedGridColumn10.Name = "bandedGridColumn10";
            this.bandedGridColumn10.Visible = true;
            // 
            // bandedGridColumn9
            // 
            this.bandedGridColumn9.Caption = "bandedGridColumn9";
            this.bandedGridColumn9.FieldName = "Name";
            this.bandedGridColumn9.Name = "bandedGridColumn9";
            this.bandedGridColumn9.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "bandedGridColumn3";
            this.bandedGridColumn3.FieldName = "Name";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            // 
            // bandedGridColumn11
            // 
            this.bandedGridColumn11.Caption = "bandedGridColumn11";
            this.bandedGridColumn11.FieldName = "Name";
            this.bandedGridColumn11.Name = "bandedGridColumn11";
            this.bandedGridColumn11.RowIndex = 1;
            this.bandedGridColumn11.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "gridBand5";
            this.gridBand5.Columns.Add(this.bandedGridColumn6);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Visible = false;
            this.gridBand5.Width = 75;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "bandedGridColumn6";
            this.bandedGridColumn6.FieldName = "Name";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "gridBand6";
            this.gridBand6.Columns.Add(this.bandedGridColumn2);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Visible = false;
            this.gridBand6.Width = 75;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "bandedGridColumn2";
            this.bandedGridColumn2.FieldName = "Name";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "gridBand7";
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.Visible = false;
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "gridBand8";
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.Visible = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 436);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
    }
}

