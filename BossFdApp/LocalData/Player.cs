using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BossFdApp.LocalData
{
    public class CPlayer
    {
        public int PId;
        public string PName;
        public int Lives;
        public bool Dodge;
        public static int PCounter;
        public CPlayer()
        {
            PCounter++;
            PId = PCounter;
            PName = "Player " + PCounter;
            Lives = 3;
            Dodge = true;
        }

        public void dodge(int chance)
        {
            Random rnd = new Random();
            int dodgeAttempt = rnd.Next(1, 101);
            if (dodgeAttempt <= chance)
                Dodge = true;
            else
            {
                Dodge = false;
                Lives--;
            }

        }
    }
}
