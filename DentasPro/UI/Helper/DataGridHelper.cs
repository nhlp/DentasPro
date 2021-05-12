namespace Dentas_Pro.UI.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using Dentas_Pro.UI.WinControl;
    using DevExpress.XtraEditors.Repository;


    public class DataGridHelper
    {
        public const int RowNotFound = -1;

        public static DataRow GetSelectedDataRow(GridView grid, GridControl gridControl)
        {
            return grid.GetDataRow(grid.FocusedRowHandle);

            //Bu hatalı oluyordu bazen, SelectedRowsCount  null oluyoru çünkü.
            //if (grid.SelectedRowsCount > 0) //phGridControl.gridView1.FocusedRowHandle 
            //{
            //    return ((DataRowView)gridControl.BindingContext[gridControl.DataSource, gridControl.DataMember].Current).Row;
            //}
            //else
            //{
            //    return null;
            //}
        }


        /// <summary>
        /// Grid üzerinde seçilen satırlara, karşılık gelen DataRow'un indexi. 
        /// (Sort yaptıktan sonra karışıyor çünkü)
        /// </summary>
        /// <param name="gridView">GridControl deki gridview</param>
        public static int GetDataRowIndex(GridView gridView, int rowHandle)
        {
            //DataRow row = gridView.GetDataRow(rowHandle);//bu da aynı şeyi verir
            //int rowIndex = row.Table.Rows.IndexOf(row);
            int rowIndex = gridView.GetDataSourceRowIndex(rowHandle);
            return rowIndex;
        }


        public static void GridColumnFormat(GridColumn column, DevExpress.Utils.FormatType formatType, string formatString, bool allowEdit)
        {
            column.DisplayFormat.FormatType = formatType;
            //if (formatType == DevExpress.Utils.FormatType.Custom)
            //    column.DisplayFormat.Format = new BaseFormatter();
            column.DisplayFormat.FormatString = formatString;
            column.OptionsColumn.AllowEdit = allowEdit;

        }


        #region SetGridVisibleColumns

        /// <summary>
        /// Verilen kolonları, veriliş sırasına göre gösterir.
        /// </summary>
        public static void SetGridVisibleColumns(FuGridControl fuGrid, params string[] visibleComuns)
        {
            GridColumnCollection cols = fuGrid.gridView1.Columns;

            for (int i = 0; i < cols.Count; i++)
            {
                cols[i].Visible = false;
            }
            for (int i = 0; i < visibleComuns.Length; i++)
            {
                cols[visibleComuns[i]].Visible = true;
                cols[visibleComuns[i]].VisibleIndex = i + 1;
            }
        }
        #endregion



        #region AddRepositoryLookUpEdit

        /// <summary>
        /// Grid satırlarında istenen tipte control açar
        /// </summary>
        public static void AddRepositoryLookUpEdit(FuGridControl fuGrid,  string columnName, string valueMember, string displayMember)
        {
            GridColumnCollection columns = fuGrid.gridView1.Columns;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            //ComboBoxHelper.FillRepositoryItemLookUpEdit(repositoryItemLookUpEdit, query, valueMember, displayMember);
            columns[columnName].ColumnEdit = repositoryItemLookUpEdit;
        }

        /// <summary>
        /// Grid satırlarında istenen tipte control açar
        /// </summary>
        public static void AddRepositoryLookUpEdit(FuGridControl fuGrid, string columnName, Type enumType)
        {
            //DataTable dataTable = Phoenix.Core.Utilities.DataTableHelper.GetDataTableFromEnum(enumType);
            //GridColumnCollection columns = phGrid.gridView1.Columns;
            //RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            //columns[columnName].ColumnEdit = repositoryItemLookUpEdit;
        }

        #endregion


    }
}
