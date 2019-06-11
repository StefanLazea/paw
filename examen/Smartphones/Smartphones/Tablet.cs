using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphones
{
    public class Tablet: Device
    {
        private int nrusb;

        public Tablet(int nrusb, int cod, string denumire, string dimensiuni, float frecvproc, int nrcore, string sistemop, float pret, bool activ) : base(cod, denumire, dimensiuni, frecvproc, nrcore, sistemop, pret, activ)
        {
            this.nrusb = nrusb;
        }
        
        public int Nrusb
        {
            get { return this.nrusb; }
            set { this.nrusb = value; }
        }

        public override ListViewItem Afisare()
        {
            ListViewItem item = new ListViewItem(this.Cod.ToString());
            item.SubItems.Add(this.Denumire);
            item.SubItems.Add(this.Dimensiune);
            item.SubItems.Add(this.Frecvproc.ToString());
            item.SubItems.Add(this.Nrcore.ToString());
            item.SubItems.Add(this.Sistemop);
            item.SubItems.Add(this.Pret.ToString());
            item.SubItems.Add(this.Activ.ToString());
            item.SubItems.Add(this.nrusb.ToString());
            item.Tag = this;
            return item;
        }
        public override string ToString()
        {
            return base.ToString() + " si are " + this.nrusb + " usb";
        }
    }
}
