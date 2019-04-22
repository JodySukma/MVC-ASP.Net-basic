using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoalKe_1.Models
{
    public class KalkulatorModel
    {
        //private double _angka1;
        //private double _angka2;

        //private string _operator;

        //public double Angka1 { get => _angka1; set => _angka1 = 0; }
        //public double Angka2 { get => _angka2; set => _angka2 = 0; }
        public double Angka1 { get; set; } = 0;
        public double Angka2 { get; set; } = 0;

        public string Operator { get; set; } = "+";

        public double Hasil
        {
            get {
                if (Operator == "+")
                    return Angka1 + Angka2;
                else if (Operator == "-")
                    return Angka1 - Angka2;
                else if (Operator == "*")
                    return Angka1 * Angka2;
                else
                    return Angka1 / Angka2;
            }
        }
    }
}
