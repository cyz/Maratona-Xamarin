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
using Modulo5.Droid.Services;
using Modulo5.Services;
using Xamarin.Forms;

[assembly:Dependency(typeof(PlatformNameService))]
namespace Modulo5.Droid.Services
{
    public class PlatformNameService : IPlatformNameService
    {
        public string GetPlatformName()
        {
            return "Hello from Android";
        }
    }
}