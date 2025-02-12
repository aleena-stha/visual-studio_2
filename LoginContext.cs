using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstDesktop
{
    public class LoginContext : ApplicationContext
    {
        #region Private Fields
        // here we can declare all forms application and manage it directly
        // (show,close,set as MainForm and so on)
        private FrmSplash _FrmSplash;
        private FrmLogin _fLogin;
        private MDIMainForm _fmain;

        #endregion
        #region Initialization

        public LoginContext()
        {
            CreateSplashForm();
            //creatingLoginform;
        }

        #endregion
        #region Private Methods

        ////public void CreateSplashForm()
        //{
           // _FrmSplash = new FrmSplash();
           FrmSplash.Closed += new EventHandler(FrmSplash_Closed);
            MDIMainForm = FrmSplash;
            FrmSplash.Show();
        }

        private void FrmSplash_Closed(object sender, EventArgs e)
        {
            if (_FrmSplash.ShowLoginForm)
            {

                Create FrmLogin();
            }
            else
            {
                Application.Exit();
            }
        }

        private void CreateLoginForm();
        {
        _FrmLogin = new FrmLogin();
        _fLogin.Closed += new EventHandler(fLogin_Closed);
        this.MainForm =_fLogin;
            _fLogin.Show();
         }

    void fLogin_Closed(object  sender ,EventArgs e)
    {
        //if (LWork.LoginWork.Logged )// if the user is logged
        var a = 1;
        if (CommonInfo.StaffID !=0)
    }

    }

}
