/*Image'ları DB'ye kaydetme ve okuma için*/
namespace Dentas_Pro.UI.DAL_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Drawing;

    /// <summary>
    /// 1_1_56_47
    /// Resimleme
    /// </summary>
    public  class Imaging
    {

        #region Description
        /*
         * 1_1:50
         * Resmimizi yüklemek amacı ile parametre olarak resim gönderiyoruz
         * Resmi memoryStream ile okuyoruz.
         */
        #endregion
        public byte[] Load_The_Image(System.Drawing.Image Image) 
        {
            using (MemoryStream memoryStream = new MemoryStream()) 
            {
                /*Jpeg formatında okuyoruz ve*/
                Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                /*
                 * array haline getiriyoruz
                 * Daha sonrada Image'ı binary olarak kapsülleyip
                 * DB'ye gönderceğiz.
                 */
                return memoryStream.ToArray();
            }
        }

        /*
         * Bu metod da DB'den okuma yapmak için
         * Image DB'den binary'den array olarak gelecek.
         * array olarak gelen dosyayı açacağız.
         * ResimGetirme
         */
        public Imaging Get_The_Image(byte[] Getting_Image_Byte_Array) 
        {
            using (MemoryStream memory_stream = new MemoryStream(Getting_Image_Byte_Array)) 
            {
                /*GEleb dosyayı burda Image dosyası haline getiriyoruz.*/
                //Image image = Image.FromStream(memory_stream);

                Imaging image = Imaging.FromStream(memory_stream);

                /*ve resim olara döndüreceğiz.*/
                return image;
            }

        }

        private static Imaging FromStream(MemoryStream memory_stream)
        {
            throw new NotImplementedException();
            
        }
    }
}

