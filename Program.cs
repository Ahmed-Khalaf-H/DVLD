using DVLD;
using System;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);




        //Application.Run(new frm_ManageUsers());
        bool restartApp;

        do
        {
            restartApp = false;

            using (var loginForm = new frm_Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    using (var mainForm = new frm_MainForm())
                    {
                        if (mainForm.ShowDialog() == DialogResult.Retry)
                        {
                            restartApp = true;
                        }
                    }
                }
            }
        } while (restartApp);
    }
}