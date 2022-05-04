using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_App
{
    public class PandaFactory
    {
        public PandaFactory()
        {
        }

        /*
         * 0 - "🐼 + 🐬 = 🔪🐳"
         * 1 - "🐼 + 📖 = 📰"
         * 2 - "🐼 + 🐼 = 🐼"
         * 3 - "🐼 + 🐼 + 🐼 + 🐼 = Broads in Atlanta"
         */
        public String CreatePanda(int type)
        {
            switch (type)
            {
                case 0: return "🐼 + 🐬 = 🔪🐳";
                case 1: return "🐼 + 📖 = 📰";
                case 2: return "🐼 + 🐼 = 🐼";
                case 3: return "🐼 + 🐼 + 🐼 + 🐼 = Broads in Atlanta";
                default: throw new InvalidOperationException();
            }
        }
    }
}



