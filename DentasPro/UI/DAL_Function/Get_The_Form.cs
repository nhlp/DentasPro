/*formları burdan çağırıyoruz*/
namespace Dentas_Pro.UI.DAL_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Dentas_Pro.UI.User;
    using Dentas_Pro.UI.Definition;
    using DevExpress.XtraEditors;

    /// <summary>
    /// Formlar
    /// </summary>
    class Get_The_Form
    {

        public void User_Form(bool Open_Up = false, int User_Obj_Id = -1)
        {
            UI.User.User_Form user_Form = new UI.User.User_Form();

            if (Open_Up)

                user_Form.Getting_For_Open_Up_User(User_Obj_Id);
            user_Form.ShowDialog();


        }

        public int User_List(bool Choose = false)
        {
            Dentas_Pro.UI.User.User_List_Form user_List_Form = new User_List_Form();
            if (Choose)
            {
                user_List_Form.Choose = Choose;
                user_List_Form.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm Current_Forme in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (Current_Forme.Text == "Personel Listesi Formu")
                    {
                        Current_Forme.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }
                user_List_Form.MdiParent = MainMDIForm.ActiveForm;
                user_List_Form.Show();
            }
            return MainMDIForm.Cross;
            //else
            //{
            //    user_List_Form.MdiParent = MainMDIForm.ActiveForm;
            //    user_List_Form.Show();
            //}

            //return MainMDIForm.Cross;
        }

        public int Who_Is_On_Vacation_List(bool Choose = false) 
        {
            Dentas_Pro.UI.User.Who_Is_Vacation_List_Form who_Is_Vacation_List_Form = new Who_Is_Vacation_List_Form();
            if (Choose)
            {
                who_Is_Vacation_List_Form.Choose = Choose;
                who_Is_Vacation_List_Form.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm Current_Forme in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (Current_Forme.Text == "Kimler İzinde")
                    {
                        Current_Forme.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }
                who_Is_Vacation_List_Form.MdiParent = MainMDIForm.ActiveForm;
                who_Is_Vacation_List_Form.Show();
            }
            return MainMDIForm.Cross;
        }

        public int User_List_For_Responsible(bool Choose = true)
        {
            UI.User.User_List_Form user_List_Form = new UI.User.User_List_Form();
            if (Choose)
            {
                user_List_Form.Choose = Choose;
                user_List_Form.ShowDialog();
            }
            else
            {
                //user_List_Form.MdiParent = MainMDIForm.ActiveForm;
                //user_List_Form.Show();
            }

            return MainMDIForm.Cross;
        }

        public int User_List_For_Manager(bool Choose = true)
        {
            UI.User.User_List_Form user_List_Form = new UI.User.User_List_Form();
            if (Choose)
            {
                user_List_Form.Choose = Choose;
                user_List_Form.ShowDialog();
            }
            else
            {
                //user_List_Form.MdiParent = MainMDIForm.ActiveForm;
                //user_List_Form.Show();
            }

            return MainMDIForm.Cross;
        }

        public int Daily_Hour_Permit_Form(bool Open_Up = false, int User_Obj_Id = -1)
        {
            Daily_Hour_Permit_Form daily_Permit_form = new UI.User.Daily_Hour_Permit_Form();

            if (Open_Up)
            {
                daily_Permit_form.Getting_For_Saved_Daily_Hour_List(User_Obj_Id);
                daily_Permit_form.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm Current_Form in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (Current_Form.Text == "Günlük & Saatlik İzin Formu")
                    {
                        Current_Form.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }

                daily_Permit_form.MdiParent = MainMDIForm.ActiveForm;
                daily_Permit_form.Show();
            }
            return MainMDIForm.Cross;

        }


        public int Daily_Hour_Permit_List_Form(bool Choose = false)
        {
            UI.User.Daily_Hour_Permit_List_Form daily_Hour_Permit_List_Form = new Daily_Hour_Permit_List_Form();
            if (Choose)
            {
                daily_Hour_Permit_List_Form.Choose = Choose;
                daily_Hour_Permit_List_Form.ShowDialog();
            }
            else
            {
                daily_Hour_Permit_List_Form.MdiParent = MainMDIForm.ActiveForm;
                daily_Hour_Permit_List_Form.Show();
            }

            return MainMDIForm.Cross;
        }

        public int Daily_Permit_List_Form(bool Choose = false)
        {
            UI.User.Daily_Hour_Permit_List_Form daily_Hour_Permit_List_Form = new Daily_Hour_Permit_List_Form();
            if (Choose)
            {
                daily_Hour_Permit_List_Form.Choose = Choose;
                daily_Hour_Permit_List_Form.ShowDialog();
            }
            else
            {
                /*
                * Developed: İrfan_Dölek
                * Date     : 2015_03_03_:14_20
                * Bu döngü List formun birkere açılmasını enegelliyor
                */
                foreach (XtraForm CurrentForm in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (CurrentForm.Text == "Günlük & Saatlik İzin Listesi")
                    {
                        CurrentForm.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }

                daily_Hour_Permit_List_Form.MdiParent = MainMDIForm.ActiveForm;
                daily_Hour_Permit_List_Form.Show();
            }

            return MainMDIForm.Cross;
        }


        #region Descripiton
        /*Yıllık izin formu*/
        #endregion
        public int Annual_Permit_Form(bool Open_Up = false, int User_Obj_Id = -1)
        {
            Annual_Permit_Form annual_Permit_form = new Annual_Permit_Form();

            if (Open_Up)
            {
                annual_Permit_form.Getting_For_Saved_Annual_List(User_Obj_Id);
                annual_Permit_form.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm Current_Form in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (Current_Form.Text == "Yıllık İzin Talep Formu")
                    {
                        Current_Form.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }

                annual_Permit_form.MdiParent = MainMDIForm.ActiveForm;
                annual_Permit_form.Show();
            }
            return MainMDIForm.Cross;

        }

        public int Annual_Permit_List_Form(bool Choose = false)
        {
            UI.User.Annual_Permit_List_Form annual_Permit_List_Form = new Annual_Permit_List_Form();
            if (Choose)
            {
                annual_Permit_List_Form.Choose = Choose;
                annual_Permit_List_Form.ShowDialog();
            }
            else
            {
                /*
                * Developed: İrfan_Dölek
                * Date     : 2015_03_03_:14_20
                * Bu döngü List formun birkere açılmasını engelliyor
                */
                foreach (XtraForm CurrentForm in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (CurrentForm.Text == "Yıllık İzin Talep Listesi")
                    {
                        CurrentForm.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }

                annual_Permit_List_Form.MdiParent = MainMDIForm.ActiveForm;
                annual_Permit_List_Form.Show();
            }

            return MainMDIForm.Cross;
        }


        /// <summary>
        /// 2_48_00
        /// As_CariGruplari
        /// </summary>
        public int Department_Form(bool Choose = false)
        {
            Wating_Annual_Approval_Form user_Department_Register_Form = new Wating_Annual_Approval_Form();

            if (Choose)
            {
                user_Department_Register_Form.Choose = Choose;
                user_Department_Register_Form.ShowDialog();
            }
            else
            {
                user_Department_Register_Form.MdiParent = MainMDIForm.ActiveForm;
                user_Department_Register_Form.Show();
            }

            return MainMDIForm.Cross;
        }

        public int Location_Form(bool Choose = false)
        {
            Location_Form location_Form = new Definition.Location_Form();

            if (Choose)
            {
                location_Form.Choose = Choose;
                location_Form.ShowDialog();
            }
            else
            {
                location_Form.MdiParent = MainMDIForm.ActiveForm;
                location_Form.Show();
            }
            return MainMDIForm.Cross;
        }

        public int Permit_Reason_Form(bool Choose = false)
        {
            Permit_Reason_Form permit_Type_Form = new Permit_Reason_Form();
            if (Choose)
            {
                permit_Type_Form.Choose = Choose;
                permit_Type_Form.ShowDialog();
            }
            else
            {
                permit_Type_Form.MdiParent = MainMDIForm.ActiveForm;
                permit_Type_Form.Show();
            }
            return MainMDIForm.Cross;

        }

        /// <summary>
        /// Ünvan bilgilerinin kaydedildiği form
        /// </summary>
        public int Title_Form(bool Choose = false)
        {
            Dentas_Pro.UI.User.Title_Form title_Form = new Title_Form();

            if (Choose)
            {
                title_Form.Choose = Choose;
                title_Form.ShowDialog();
            }
            else
            {
                title_Form.MdiParent = MainMDIForm.ActiveForm;
                title_Form.Show();
            }
            #region Description
            /*Aktarma değerini geri gönderme*/
            #endregion
            return MainMDIForm.Cross;
        }

        /// <summary>
        /// Seyahat harcama formu
        /// 2015_01_29_14_25_00
        /// </summary>
        public void Travel_Expense_Form(bool Open_Up = false, int Obj_Id = -1)
        {
            Dentas_Pro.UI.Travel.Travel_Expense_Form travel_Expense_Form = new Travel.Travel_Expense_Form();
            if (Open_Up)
            {
                /*Travel_Expense_Form_Obj_Id --> Id yi burdan parametre olarak göderiyoruz.*/
                travel_Expense_Form = new Travel.Travel_Expense_Form(Open_Up, Obj_Id);
            }
            /*eğer açma işlemi için değilse bu kod icra olur.*/
            else
            {
                travel_Expense_Form = new Travel.Travel_Expense_Form();
            }
            travel_Expense_Form.MdiParent = MainMDIForm.ActiveForm;
            travel_Expense_Form.Show();
        }

        public int Travel_Request_Form(bool Choose = false)
        {
            Dentas_Pro.UI.Travel.Travel_Request_Form travel_Request_Form = new Travel.Travel_Request_Form();
            if (Choose)
            {
                travel_Request_Form.Choose = Choose;
                travel_Request_Form.ShowDialog();
            }
            else
            {
                travel_Request_Form.MdiParent = MainMDIForm.ActiveForm;
                travel_Request_Form.Show();
            }
            return MainMDIForm.Cross;
        }

        public int Expense_Group_Form(bool Choose = false)
        {
            Dentas_Pro.UI.Definition.Expense_Group_Form expense_Group_Form = new Expense_Group_Form();

            if (Choose)
            {
                expense_Group_Form.Choose = Choose;
                expense_Group_Form.ShowDialog();
            }
            else
            {
                expense_Group_Form.MdiParent = MainMDIForm.ActiveForm;
                expense_Group_Form.Show();
            }
            return MainMDIForm.Cross;
        }

        public int Travel_Vehicle_Form(bool Choose = false)
        {
            Dentas_Pro.UI.Definition.Travel_Vehicle_Form travel_Vehicle_Form = new Travel_Vehicle_Form();

            if (Choose)
            {
                travel_Vehicle_Form.Choose = Choose;
                travel_Vehicle_Form.ShowDialog();
            }
            else
            {
                travel_Vehicle_Form.MdiParent = MainMDIForm.ActiveForm;
                travel_Vehicle_Form.Show();
            }
            return MainMDIForm.Cross;
        }

        public int Travel_Expense_Type_Form(bool Choose = false)
        {
            Dentas_Pro.UI.Definition.Travel_Expense_Type_Form expense_Type_Form = new Travel_Expense_Type_Form();

            if (Choose)
            {
                expense_Type_Form.Choose = Choose;
                expense_Type_Form.ShowDialog();
            }
            else
            {
                expense_Type_Form.MdiParent = MainMDIForm.ActiveForm;
                expense_Type_Form.Show();
            }
            return MainMDIForm.Cross;
        }

        public int Permit_Knowledge_Form(bool Open_Up = false, int User_Obj_Id = -1)
        {
            Permit_Knowledge_Form permit_Knowledge_Form = new Permit_Knowledge_Form();

            if (Open_Up)
            {
                permit_Knowledge_Form.Getting_For_Permit_Knowledge(User_Obj_Id);
                permit_Knowledge_Form.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm Current_Form in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (Current_Form.Text == "İzin Bilgi Formu")
                    {
                        Current_Form.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }
                permit_Knowledge_Form.MdiParent = MainMDIForm.ActiveForm;
                permit_Knowledge_Form.Show();
            }
            return MainMDIForm.Cross;

        }

        public int History_Of_Annual_Premit_Form(bool Open_Up = false, int User_Obj_Id = -1)
        {
            History_Of_Annual_Premit_Form history_Of_Annual_Premit_Form = new History_Of_Annual_Premit_Form();

            if (Open_Up)
            {
                history_Of_Annual_Premit_Form.Getting_For_Permit_Knowledge(User_Obj_Id);
                history_Of_Annual_Premit_Form.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm Current_Form in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (Current_Form.Text == "Yıllık İzin Ekstresi")
                    {
                        Current_Form.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }
                history_Of_Annual_Premit_Form.MdiParent = MainMDIForm.ActiveForm;
                history_Of_Annual_Premit_Form.Show();
            }
            return MainMDIForm.Cross;

        }

        public int Add_Annual_Permit(bool Open_Up = false, int User_Obj_Id = -1)
        {
            Add_Annual_Permit_Form add_Annual_Permit_Form = new Add_Annual_Permit_Form();

            if (Open_Up)
            {
                add_Annual_Permit_Form.Getting_For_Permit_Knowledge(User_Obj_Id);
                add_Annual_Permit_Form.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm Current_Form in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (Current_Form.Text == "Personele Yillik izin Ver")
                    {
                        Current_Form.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }
                add_Annual_Permit_Form.MdiParent = MainMDIForm.ActiveForm;
                add_Annual_Permit_Form.Show();
            }
            return MainMDIForm.Cross;

        }

        public int Send_An_Email_Form(bool Open_Up = false, int User_Obj_Id = -1)
        {
            UI.Mail.Send_An_E_Mail send_An_E_Mail = new Mail.Send_An_E_Mail();

            send_An_E_Mail.MdiParent = MainMDIForm.ActiveForm;
            send_An_E_Mail.Show();
            //if (Open_Up)
            //{
            //    send_An_E_Mail.Getting_For_Permit_Knowledge(User_Obj_Id);
            //    send_An_E_Mail.ShowDialog();
            //}
            //else
            //{
            //    foreach (DevExpress.XtraEditors.XtraForm Current_Form in MainMDIForm.ActiveForm.MdiChildren)
            //    {
            //        if (Current_Form.Text == "İzin Bilgi Formu")
            //        {
            //            Current_Form.BringToFront();
            //            return MainMDIForm.Cross;
            //        }
            //    }
            //    permit_Knowledge_Form.MdiParent = MainMDIForm.ActiveForm;
            //    permit_Knowledge_Form.Show();
            //}
            return MainMDIForm.Cross;

        }

        public int Recycle_Accounting_Form(bool Open_Up = false, int user_Obj_Id = -1)
        {
            UI.Recycle.Recycle_Accounting_Form recycle_Accounting_Form = new Recycle.Recycle_Accounting_Form();
            recycle_Accounting_Form.MdiParent = MainMDIForm.ActiveForm;
            recycle_Accounting_Form.Show();

            return MainMDIForm.Cross;
        }

        /// <summary>
        /// Departman performans raporu
        /// </summary>
        public int Staff_Rest_Permit_List_Form_Graphic()
        {
            UI.Report.Staff_Rest_Permit_List_Form_Graphic staff_Rest_Permit_List_Form_Graphic = new Report.Staff_Rest_Permit_List_Form_Graphic();
            staff_Rest_Permit_List_Form_Graphic.MdiParent = MainMDIForm.ActiveForm;
            staff_Rest_Permit_List_Form_Graphic.Show();

            return MainMDIForm.Cross;

        }
        /// <summary>
        /// Personel kalan izin
        /// </summary>
        public int Staff_Rest_Permit_List_Form(bool Choose = false)
        {
            UI.Report.Staff_Rest_Permit_List_Form staff_Rest_Permit_List_Form = new Report.Staff_Rest_Permit_List_Form();
            if (Choose)
            {
                staff_Rest_Permit_List_Form.Choose = Choose;
                staff_Rest_Permit_List_Form.ShowDialog();
            }
            else
            {
                /*
                * Developed: İrfan_Dölek
                * Date     : 2015_03_03_:14_20
                * Bu döngü List formun birkere açılmasını enegelliyor
                */
                foreach (XtraForm CurrentForm in MainMDIForm.ActiveForm.MdiChildren)
                {
                    if (CurrentForm.Text == "Personel Kalan İzin Listesi")
                    {
                        CurrentForm.BringToFront();
                        return MainMDIForm.Cross;
                    }
                }

                staff_Rest_Permit_List_Form.MdiParent = MainMDIForm.ActiveForm;
                staff_Rest_Permit_List_Form.Show();
            }

            return MainMDIForm.Cross;
        }

        public int Wating_Approval_List_Form(bool Choose = false)
        {
            UI.Permit.Waiting_Annual_Approval_Form wating_Approval_List_Form = new UI.Permit.Waiting_Annual_Approval_Form();
            if (Choose)
            {
                wating_Approval_List_Form.Choose = Choose;
                wating_Approval_List_Form.ShowDialog();
            }
            foreach (XtraForm CurrentForm in MainMDIForm.ActiveForm.MdiChildren)
            {
                if (CurrentForm.Text == "Onay Bekleyen Yıllık İzinler")
                {
                    CurrentForm.BringToFront();
                    return MainMDIForm.Cross;
                }
                wating_Approval_List_Form.MdiParent = MainMDIForm.ActiveForm;
                wating_Approval_List_Form.Show();
            }
            return MainMDIForm.Cross;
        }

        public int Holiday_Set_Form(bool Choose = false)
        {
            UI.Permit.Holiday_Set_Form holiday_Set_Form = new UI.Permit.Holiday_Set_Form();

            if (Choose)
            {
                holiday_Set_Form.Choose = Choose;
                holiday_Set_Form.ShowDialog();
            }
            else
            {
                holiday_Set_Form.MdiParent = MainMDIForm.ActiveForm;
                holiday_Set_Form.Show();
            }

            return MainMDIForm.Cross;
        }
    }
}
