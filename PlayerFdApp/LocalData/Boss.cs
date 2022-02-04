using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerFdApp.LocalData
{
    public class CBoss
    {
        public string BName;
        public int Action;

        public CBoss()
        {
            BName = "";
            Action = 0;
        }

        public void attack()
        {
            Random rnd = new Random();
            Action = rnd.Next(1, 6);
        }
    }
}
