using System;
using System.Collections.Generic;
using System.Text;

namespace Skat
{
    public abstract class Afgift
    {

        private int afgift1 = 85;
        private int afgift2 = 150;
        private int fradrag = 130000;
        private int elBilAfgift = 20;

        /// <summary>
        /// BilAfgift returnere afgiften på på den angivne bilpris,
        /// Hvis prisen er mindre end eller = 200.000 er afgiften 85% af bilens pris
        /// Hvis prisen er over 200.000 er afgiften 150% minus 130.000.
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public virtual int BilAfgift(int pris)
        {

            if (pris <= 200000 && pris > 0)
            {
                return (pris * afgift1)/100;
            }

            else if(pris > 200000)
            {
                return (pris * afgift2)/100 - fradrag;
            }

            return 0;
        }

        /// <summary>
        /// Elbilafgift returnere afgiften på elbiler. Elbil afgiften er 20% af den alm. bilafgift.
        /// Hvis prisen er mindre end eller = 200.000 er afgiften 85% af bilens pris - 20% af denne pris er ElAfgiften
        /// Hvis prisen er over 200.000 er afgiften 150% minus 130.000 - 20% af denne pris er ElAfgiften
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public virtual int ElBilAfgift(int pris)
        {
            if (pris <= 200000 && pris > 0)
            {
                return ((pris * afgift1)/100)*elBilAfgift/100;
            }

            else if (pris > 200000)
            {
                return ((pris * afgift2)/100 - fradrag)*elBilAfgift/100;
            }

            return 0;
        }
    }
}
