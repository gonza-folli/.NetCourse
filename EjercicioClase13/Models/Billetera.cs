using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase13.Models
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public Billetera()
        {
        }

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
        public void VaciarBilletera()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }
        public decimal Total()
        {
            return BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;
        }

        public Billetera Combinar(Billetera billetera1, Billetera billetera2)
        {
            int cantidadBilletes10 = billetera1.BilletesDe10 + billetera2.BilletesDe10;
            int cantidadBilletes20 = billetera1.BilletesDe20 + billetera2.BilletesDe20;
            int cantidadBilletes50 = billetera1.BilletesDe50 + billetera2.BilletesDe50;
            int cantidadBilletes100 = billetera1.BilletesDe100 + billetera2.BilletesDe100;
            int cantidadBilletes200 = billetera1.BilletesDe200 + billetera2.BilletesDe200;
            int cantidadBilletes500 = billetera1.BilletesDe500 + billetera2.BilletesDe500;
            int cantidadBilletes1000 = billetera1.BilletesDe1000 + billetera2.BilletesDe1000;
            billetera1.VaciarBilletera();
            billetera2.VaciarBilletera();
            var billetera3 = new Billetera(cantidadBilletes10, cantidadBilletes20, cantidadBilletes50, cantidadBilletes100, cantidadBilletes200, cantidadBilletes500, cantidadBilletes1000);
            return billetera3;
        }
    }
}
