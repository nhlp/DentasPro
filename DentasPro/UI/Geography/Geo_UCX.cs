namespace Dentas_Pro.UI.Geography
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using DevExpress.XtraEditors;

    public partial class Geo_UCX : UserControl
    {

        private Geo_Type geo_Type;
        private long? selected_Geo_Obj_Id;
        public delegate void SelectedGeoChanged(object sender, EventArgs e);
        public event SelectedGeoChanged FuGeo_Changed;

        public Geo_UCX()
        {
            InitializeComponent();
        }

        #region Properties
        public long? SelectedGeoId
        {
            get
            {
                selected_Geo_Obj_Id = Convert.ToInt64(FuLookUpEdit.EditValue);
                return selected_Geo_Obj_Id;
            }
            set
            {
                selected_Geo_Obj_Id = value;
                FuLookUpEdit.EditValue = selected_Geo_Obj_Id;
            }
        }
        public string SelectedGeoName
        {
            get { return FuLookUpEdit.Text; }

        }
        public Geo_Type GeoType
        {
            get { return geo_Type; }
            set
            {
                geo_Type = value;
                Fill_Geo_Look_Up_Edit();
            }
        }

        private long? associatedGeoId;
        public long? AssociatedGeoId
        {
            set
            {
                associatedGeoId = value;
                Fill_Geo_Look_Up_Edit();
            }
        }
        #endregion



        private void Fill_Geo_Look_Up_Edit() 
        {
            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select GeoName From [Geo] ", sqlConnection);


            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    FuLookUpEdit.EditValue = sqlDataReader.GetString(0);
                }
            }
        }



        private void FuLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (FuGeo_Changed != null)
                FuGeo_Changed(sender, e);
        }


       
    }
}
