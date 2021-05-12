#region Description
/*
 * 2015.01.08
 * Yapı enumdan okunacak hale getirilecek
 */
#endregion
namespace Dentas_Pro.DTO.Permit
{
    /*İzin sebebi*/
    public enum Permit_Reason_Id
    {
        None = 0,
        #region Description
        /*Mazeret*/
        #endregion
        Excuse = 1,

        #region Description
        /*Evlilik*/
        #endregion

        Marriage = 2,
        #region Description
        /*Taşınma*/
        #endregion
        Move = 3,

        #region Description
        /*Doğum*/
        #endregion
        Birth = 4,

        #region Description
        /*Ölüm*/
        #endregion
        Deadth = 5,

        #region Desciption
        /*Sünnet*/
        #endregion
        Circumcision = 6,

        #region Description
        /*Diğer*/
        #endregion
        Other = 7



    }
}
