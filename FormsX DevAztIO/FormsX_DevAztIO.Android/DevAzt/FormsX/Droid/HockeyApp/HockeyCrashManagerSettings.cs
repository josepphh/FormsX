using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HockeyApp.Android;
using FormsX_DevAztIO;

namespace DevAzt.FormsX.Droid.HockeyApp
{
    
    public class HockeyCrashManagerSettings : CrashManagerListener
    {
        Application _application;

        public HockeyCrashManagerSettings(Application app)
        {
            _application = app;
        }

        public override string UserID
        {
            get
            {
                string iduser = "0";
                return iduser;
            }
        }

        public override string Description
        {
            get
            {
                string description = "";
                return description;
            }
        }

        public override bool ShouldAutoUploadCrashes()
        {
            return true;
        }
    }
}