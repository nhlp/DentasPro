namespace Dentas_Pro.UI.Helper
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Card;
    using DevExpress.XtraGrid.Views.Grid;

    public partial class GridEditDataInPopupForm : Form
    {
        public GridEditDataInPopupForm()
        {
            InitializeComponent();
        }

        public DataRow Row
        {
            get { return cardView1.GetDataRow(0); }
            //get { return CardView}
        }

        private void InitLocation(Form frm)
        {
            this.Top = frm.Top + (frm.Height - this.Height) / 2;
            this.Left = frm.Left + (frm.Width - this.Width) / 2;
        }

        public void InitData(Form frm, GridControl grid, GridView view, DataRow row)
        {
            InitLocation(frm);
            foreach (GridColumn col in view.Columns)
            {
                GridColumn column = cardView1.Columns.Add();
                column.Caption = col.Caption;
                column.FieldName = col.FieldName;
                column.ColumnEdit = col.ColumnEdit;
                column.DisplayFormat.Assign(col.DisplayFormat);
                column.VisibleIndex = col.VisibleIndex;
            }
            DataTable tbl = ((DataTable)grid.DataSource).Clone();
            tbl.Rows.Add(row.ItemArray);
            gridControl1.DataSource = tbl;
            cardView1.FocusedColumn = cardView1.Columns[0];
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            Row.EndEdit();
        }
    }
}
