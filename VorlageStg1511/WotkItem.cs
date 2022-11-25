using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VorlageStg1511
{
    public class WotkItem
    {
        private string message;
        public string Message
        { 
           get { return message; }
        }

        private string buttontext;
        public string ButtonText
        {
            get { return buttontext; }
        }
        public WotkItem()
        {
            message = "Hallo";
            buttontext= "Drück mich";
        }
        
    }
}
