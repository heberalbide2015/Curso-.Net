using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13.Modelo
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100, int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            BilletesDe10 = billetesDe10;
            BilletesDe20 = billetesDe20;
            BilletesDe50 = billetesDe50;
            BilletesDe100 = billetesDe100;
            BilletesDe200 = billetesDe200;
            BilletesDe500 = billetesDe500;
            BilletesDe1000 = billetesDe1000;
        }

        public decimal Total()
        {
            return BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;

        }

        public void Vaciar()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }

        public Billetera Combinar(Billetera otraBilletera)
        {
            Billetera combinada = new Billetera(BilletesDe10 + otraBilletera.BilletesDe10, BilletesDe20 + otraBilletera.BilletesDe20, BilletesDe50 + otraBilletera.BilletesDe50, BilletesDe100 + otraBilletera.BilletesDe100, BilletesDe200 + otraBilletera.BilletesDe200, BilletesDe500 + otraBilletera.BilletesDe500, BilletesDe1000 + otraBilletera.BilletesDe1000);
            Vaciar();
            otraBilletera.Vaciar();
            return combinada;
        }
    }
}
