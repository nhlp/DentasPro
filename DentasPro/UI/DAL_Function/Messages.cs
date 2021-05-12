
namespace Dentas_Pro.UI.DAL_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    class Messages
    {
        public void New_Record(string Message) 
        {
            MessageBox.Show(Message, "Yeni kayıt girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Update() 
        {
            return MessageBox.Show("Seçtiğiniz kayıt güncellencektir \n Güncelleme işlemini onaylıyormusunuz ?" , "Silme İşlmei", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #region Description
        /*Dikkat edersen ika tane aynı isimde metod var. Buna overload denir.*/
        /*2015.01.07_update isimli diğer bir metod olduğu için hata veriyor, bu sebeple bu metoda fazladan _ konuldu. 
         * Hatanın sebebi: Metod isimlerinin aynı olması değil. Metod isimleri aynı olduğunda overload metod olmuş oluyor
         * metoda farklı parametreler vererek overload yapılmalı. Parametre vermeyi unutma.
         */
        #endregion
        public void Update(bool Update_Message) 
        {
            MessageBox.Show("Kayıt güncellenmiştir..." , "kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Delete() 
        {
            return MessageBox.Show("Seçtiğiniz kayıt silinecektir \n Silmeyi onaylıyor musunuz?", "Silme İşlmi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
        }

        public void Error(Exception Error_Exception) 
        {
            MessageBox.Show(Error_Exception.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warning(Exception Warning_Message) 
        {
            MessageBox.Show(Warning_Message.Message,"alanı boş geçemzsiniz",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
