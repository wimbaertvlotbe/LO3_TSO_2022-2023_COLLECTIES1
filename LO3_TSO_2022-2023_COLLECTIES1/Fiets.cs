using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO3_TSO_2022_2023_COLLECTIES1
{
    internal class Fiets
    {
        double prijs;
        public string Merk
        { get; set; } 
        public string Categorie
        { get; set; } 
        public string Type
        { get; set; } 
        public double Prijs
        {
            get { return prijs; }
            set { if (value >= 0) prijs = value; }
        }

        public Fiets(string merk, string categorie, string type, double prijs)
        {
            Merk = merk;
            Categorie = categorie;
            Type = type;
            this.prijs = prijs;
        }

        public override string ToString()
        {
            return $"merk : {Merk.PadRight(20)} categorie : {Categorie.PadRight(10)} type : {Type.PadRight(30)} prijs : {prijs.ToString("C", CultureInfo.CurrentCulture)}";
        }

    }
}
