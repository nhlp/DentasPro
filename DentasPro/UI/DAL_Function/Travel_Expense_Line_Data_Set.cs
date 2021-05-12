namespace Dentas_Pro.UI.DAL_Function 

{
/// <summary>
/// 2015_02_11
/// İrfan_Dölek
/// Data_Table nesnesinin kolonlarına ad verirken ilişkili olacak "dbo.Table.Column" aynı olması daha hatırlatcı olur.
/// Yaklaşım'ın bu olmalı
/// 
/// Hangi kolonlar olmalı_?
/// Gerid'i besleyecek kolnlar yeterli
/// </summary>
    

    /*
     * Dikkat
     *DataSetteki DataTable'a aldığın değer'in type'i ile db'de kolon'un tipi aynı olmalı.
     *aksi takdirde tip hatası alırsın
     * 
     */
    
    
    public partial class Travel_Expense_Line_Data_Set 
    {
        /// <summary>
        /// Travel_Expense_Obj_Id --> Id olacak ama ekranda ID'ye karşılık gelecek string (Harcama_türü_adı) gösterilecek
        /// </summary>
        partial class Travel_Expense_LineDataTable
        {
        }
    }
}
