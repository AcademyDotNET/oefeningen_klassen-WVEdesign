using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bookmark_Manager_Hidden
{
    class HiddenBookMark : BookMark
    {
        public override void OpenSite()
        {
            //Process.Start("chrome.exe", "-incognito " + URL);
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "-incognito " + URL);
        }
    }
}
