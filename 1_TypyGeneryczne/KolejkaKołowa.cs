using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    public class KolejkaKołowa
    {
        private double[] bufor;
        private int początekBufora;
        private int koniecBufora;
        public KolejkaKołowa() : this (pojemność:5)
        {
                
        }
        public KolejkaKołowa(int pojemność)
        {
            bufor = new double[pojemność + 1];
            początekBufora = 0;
            koniecBufora = 0;
        }
        public void Zapisz(double wartość)
        {
            bufor[koniecBufora] = wartość;
            koniecBufora = (koniecBufora + 1) % bufor.Length;
            if (koniecBufora == początekBufora)
                początekBufora = (początekBufora + 1) % bufor.Length;
        }
        public double Czytaj()
        {
            var wynik = bufor[początekBufora];
            początekBufora = (początekBufora + 1) % bufor.Length;
            return wynik;
        }
        public int Pojemność
        {
            get
            {
                return bufor.Length;
            }
        }
        public bool JestPusty
        {
            get
            {
                return koniecBufora == początekBufora;
            }
        }
        public bool JestPełny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == początekBufora;
            }
        }
    }
}
