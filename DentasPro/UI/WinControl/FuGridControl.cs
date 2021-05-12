namespace Dentas_Pro.UI.WinControl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Views.Grid.ViewInfo;
    using System.Windows.Forms;
    using DevExpress.XtraGrid.Views.Grid;
    using System.Data;
    using Dentas_Pro.UI.Helper;

    public partial class FuGridControl : GridControl
    {
        public FuGridControl()
        {
            InitializeComponent();
        }

        public FuGridControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public int[] FuSelectedRowsIndexes
        {
            get
            {
                int[] rowHandlers = gridView1.GetSelectedRows();
                int[] rowIndexes = new int[rowHandlers.Length];
                for (int i = 0; i < rowHandlers.Length; i++)
                {
                    rowIndexes[i] = DataGridHelper.GetDataRowIndex(gridView1, rowHandlers[i]);
                }
                return rowIndexes;
            }
        }


        public DataRow FuGetSelectedRow
        {
            get
            {
                return Dentas_Pro.UI.Helper.DataGridHelper.GetSelectedDataRow(this.gridView1, this);
            }
        }

        /// <summary>
        /// Gridde sort işlemi yapıldığında satırların yeri değişir. 
        /// Bu yüzden satırın gerçek index'ini verir. 
        /// </summary>
        public int FuGetSelectedRowIndex
        {
            get
            {
                if (FuGetSelectedRow == null) return -1;
                return FuGetSelectedRow.Table.Rows.IndexOf(FuGetSelectedRow);
            }
        }

        public DataRow[] FuSelectedRows
        {
            get
            {
                #region Old code

                //if (PhSelectedRowsIndexes.Length == 0) return null;
                //DataTable dt = this.DataSource as DataTable;
                //if (dt == null) return null;


                //int[] selectedIndex = PhSelectedRowsIndexes;
                //DataRow[] rows = new DataRow[selectedIndex.Length];

                //for (int i = 0; i < selectedIndex.Length; i++)
                //{
                //    if (selectedIndex[i] >= 0)
                //        rows[i] = dt.Rows[selectedIndex[i]];
                //}

                //return rows;
                #endregion

                int[] rowHandlers = gridView1.GetSelectedRows();
                DataRow[] rows = new DataRow[rowHandlers.Length];
                for (int i = 0; i < rowHandlers.Length; i++)
                {
                    rows[i] = gridView1.GetDataRow(rowHandlers[i]);
                }
                return rows;
            }
        }



        public bool FuHasSelectedRows
        {
            get { return FuSelectedRows != null && FuSelectedRows.Length > 0; }
        }

        public long FuSelectedEntityId
        {
            get
            {
                if (!FuHasSelectedRows)
                    return 0L;
                return Convert.ToInt64(FuGetSelectedRow["Obj_Id"]);
            }
        }

        public bool FuMultiSelect
        {
            get
            {
                //gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                return gridView1.OptionsSelection.MultiSelect;
            }
            set
            {
                gridView1.OptionsSelection.MultiSelect = value;
            }
        }

        public bool FuShowAutoFilterRows
        {
            get { return gridView1.OptionsView.ShowAutoFilterRow; }
            set { gridView1.OptionsView.ShowAutoFilterRow = value; }
        }

        public bool FuShowFooter
        {
            get { return gridView1.OptionsView.ShowFooter; }
            set { gridView1.OptionsView.ShowFooter = value; }
        }

        public bool FuShowColumnHeaders
        {
            get { return gridView1.OptionsView.ShowColumnHeaders; }
            set { gridView1.OptionsView.ShowColumnHeaders = value; }
        }

        public bool FuShowVertLines
        {
            get { return gridView1.OptionsView.ShowVertLines; }
            set { gridView1.OptionsView.ShowVertLines = value; }
        }

        public bool FuShowHorzLines
        {
            get { return gridView1.OptionsView.ShowHorzLines; }
            set { gridView1.OptionsView.ShowHorzLines = value; }
        }

        /// <summary>
        /// Kolonları sürükleyerek gruplama
        /// </summary>
        public bool FuShowGroupPanel
        {
            get { return gridView1.OptionsView.ShowGroupPanel; }
            set { gridView1.OptionsView.ShowGroupPanel = value; }
        }

        public bool FuAllowColumnMoving
        {
            get { return gridView1.OptionsCustomization.AllowColumnMoving; }
            set { gridView1.OptionsCustomization.AllowColumnMoving = value; }
        }

        public bool FuAllowColumnResizing
        {
            get { return gridView1.OptionsCustomization.AllowColumnResizing; }
            set { gridView1.OptionsCustomization.AllowColumnResizing = value; }
        }

        public bool FuAllowFilter
        {
            get { return gridView1.OptionsCustomization.AllowFilter; }
            set { gridView1.OptionsCustomization.AllowFilter = value; }
        }

        public bool FuAllowRowSizing
        {
            get { return gridView1.OptionsCustomization.AllowRowSizing; }
            set { gridView1.OptionsCustomization.AllowRowSizing = value; }
        }

        public bool FuAllowSort
        {
            get { return gridView1.OptionsCustomization.AllowSort; }
            set { gridView1.OptionsCustomization.AllowSort = value; }
        }


        public bool FuAllowIncrementalSearch
        {
            get { return gridView1.OptionsBehavior.AllowIncrementalSearch; }
            set { gridView1.OptionsBehavior.AllowIncrementalSearch = value; }
        }

        public bool FuEditable
        {
            get { return gridView1.OptionsBehavior.Editable; }
            set
            {
                gridView1.OptionsBehavior.Editable = value;
                this.EmbeddedNavigator.Buttons.Append.Enabled = value;
                this.EmbeddedNavigator.Buttons.Remove.Enabled = value;
                this.EmbeddedNavigator.Buttons.Edit.Enabled = value;

            }
        }


        public bool FuColumnAutoWidth
        {
            get { return gridView1.OptionsView.ColumnAutoWidth; }
            set { gridView1.OptionsView.ColumnAutoWidth = value; }
        }

        public NewItemRowPosition FuNewItemRowPosition
        {
            get { return gridView1.OptionsView.NewItemRowPosition; }
            set { gridView1.OptionsView.NewItemRowPosition = value; }
        }



        /// <summary>
        /// Grid satırlarının gerçekten fare ile tıklandığını dönderir. 
        /// Gridin başlık gibi satır dışında bir yeri tıklanırsa false dönderir.
        /// </summary>
        public bool FuIsRowHitted
        {
            get
            {
                return FuGridHitInfo.RowHandle >= 0;
            }
        }

        /// <summary>
        /// Gridin tıklanan yeri ile ilgili bilgileri verir.
        /// Column mu, cell mi vs..
        /// </summary>
        public GridHitInfo FuGridHitInfo
        {
            get
            {
                System.Drawing.Point point = (this as Control).PointToClient(Control.MousePosition);
                GridHitInfo hitInfo = gridView1.CalcHitInfo(point);
                return hitInfo;
            }
        }

    }
}
