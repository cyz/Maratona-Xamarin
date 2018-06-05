using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Modulo5.iOS.Services;
using Modulo5.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformNameService))]
namespace Modulo5.iOS.Services
{
    public class PlatformNameService : IPlatformNameService
    {
        public string GetPlatformName()
        {
            return "Hello from iOS";
        }
    }
}