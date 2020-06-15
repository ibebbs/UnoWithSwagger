using System;

namespace Cheeze.App.Droid.Platform
{
    public partial class Services
    {
        void GetBaseAddress(ref Uri uri)
        {
            uri = new Uri("http://10.0.2.2:5000");
        }
    }
}