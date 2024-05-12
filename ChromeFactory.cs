using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca4
{
    public class ChromeFactory : LoginPageFactory
    {
        public override LoginPage CreatePage()
        {
            return new ChromeLoginPage();
        }
    }
}
