using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager.Shared
{
    public struct Char
    {
        public string name;
        public BigInteger healt;
        public BigInteger maxhealt;
        public XP xp;
        public Char(string name,BigInteger maxhealt)
        {
            this.name = name;
            healt = maxhealt;
            this.maxhealt = maxhealt;
            xp = new XP();
        }
    }
    public struct XP
    {
        public BigInteger xp;
        public BigInteger xpn;
        public BigInteger xpd;
        public BigInteger lvl;
        public Func<bool> trigger;
        public XP(BigInteger xpn,BigInteger xpd,Func<bool> trigger)
        {
            xp = 0;
            lvl = 0;
            this.xpn= xpn;
            this.xpd = xpd;
            this.trigger = trigger;
        }
        public void Check()
        {
            if (xp >= xpn)
            {
                xp -= xpn;
                lvl++;
                trigger();
            }
        }
    }
    
}
