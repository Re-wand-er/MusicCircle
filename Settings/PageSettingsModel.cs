using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MusicCircle.Settings
{
    internal class PageSettingsModel
    {
        public string PageTitle { get; set; }
        public object OpenUserControl { get; set; }

        public PageSettingsModel(string page, object _page) 
        { 
            PageTitle = page;
            OpenUserControl = _page;
        }
    }
}
