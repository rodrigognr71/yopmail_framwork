using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWebBootcamp.src.code.factoryBrowser
{
    internal class FactoryBrowser
    {
        public static IBrowser Make(String type)
        { 
            IBrowser browser;

            switch (type)
            {
                case "Chrome":
                    browser = new Chrome();
                    break;

                case "FireFox":
                    browser = new Firefox(); 
                    break;

                case "Edge":
                    browser = new Edge();
                    break;

                default:
                    browser = new Chrome();
                    break;

            }
            return browser;

        }
    }
}
