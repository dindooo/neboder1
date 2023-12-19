using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboderOcjena
{
    internal class Neboder
    {
       
        private float visina;
        private int brojKatova;

        public Neboder()
        {
        }

        public void setVisina(float visina)
        {
            this.visina = visina;
        }
        public float getVisina()
        {
            return this.visina;
        }
        public void setBrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }
        public int getBrojKatova()
        {
            return this.brojKatova;
        }

        public Neboder(float visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }

        public override string ToString()
        {
            string ispis = "Visina " + this.getVisina() + " Broj katova " + this.getBrojKatova() + " Prosjek je " + this.getVisina()/this.getBrojKatova();
            return ispis;
        }
    }

}
