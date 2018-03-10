using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using MouseButtons = System.Windows.Forms.MouseButtons;


namespace Projeto_A.Model_Object_Repository
{
    public class M_ModelPage
    {

        public static HtmlHyperlink Btn_ViewPlane(BrowserWindow _browserWindow)
        {

            var homeHyperlink = new HtmlHyperlink(_browserWindow);
            homeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "View Plane";
            homeHyperlink.SearchProperties.Add(HtmlCustom.PropertyNames.TagName, "A");

            return homeHyperlink;
        }
        
    }
}
