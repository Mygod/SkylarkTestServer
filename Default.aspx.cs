using System;
using System.Globalization;
using System.IO;
using System.Web.UI;

namespace Mygod.Skylark.TestServer
{
    public partial class Default : Page
    {
        protected DriveInfo CurrentDrive;

        private static readonly string[]
            Units = { "字节", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB", "BB", "NB", "DB", "CB" };
        public static string GetSize(long size)
        {
            double byt = size;
            byte i = 0;
            while (byt > 1000)
            {
                byt /= 1024;
                i++;
            }
            return i == 0 ? size.ToString("N0") + " 字节"
                          : byt.ToString("N") + " " + Units[i] + " (" + size.ToString("N0") + " 字节)";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentDrive = new DriveInfo(Server.MapPath("/")[0].ToString(CultureInfo.InvariantCulture));
            Response.ContentType = "text/javascript";
        }
    }
}