using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    public class battleship
    {
        int BugY, BugX;
        int HeckY, HeckX;
        string Shipdef = "bat";
        int Length = 5;
        static int bcnt = 1;
        public battleship(int BugY, int BugX, int HeckY, int HeckX)
        {
            --bcnt;
            this.BugX = BugX;
            this.BugY = BugY;
            this.HeckX = HeckX;
            this.HeckY = HeckY;
        }
        public static int _bcnt
        {
            get{ return bcnt; }
        }
    }

    public class cruiser
    {
        int BugY, BugX;
        int HeckY, HeckX;
        string Shipdef = "cru";
        int Length = 4;
        static int ccnt = 2;
        public cruiser(int BugY, int BugX, int HeckY, int HeckX)
        {
            --ccnt;
            this.BugX = BugX;
            this.BugY = BugY;
            this.HeckX = HeckX;
            this.HeckY = HeckY;
        }
    }

    public class destroyer 
    {
        int BugY, BugX;
        int HeckY, HeckX;
        string Shipdef = "des";
        int Length = 3;
        static int dcnt = 3;
        public destroyer(int BugY, int BugX, int HeckY, int HeckX)
        {
            --dcnt;
            this.BugX = BugX;
            this.BugY = BugY;
            this.HeckX = HeckX;
            this.HeckY = HeckY;
        }
    }

    public class submarine
    {

        int BugY, BugX;
        int HeckY, HeckX;
        string Shipdef = "sub";
        int Length = 2;
        static int scnt = 4;

        public submarine(int BugY, int BugX, int HeckY, int HeckX)
        {
            --scnt;
            this.BugX = BugX;
            this.BugY = BugY;
            this.HeckX = HeckX;
            this.HeckY = HeckY;
        }
    }
}
