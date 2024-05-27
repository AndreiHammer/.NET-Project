using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Film:ICloneable, IComparable , IDetails
    {
        private string titlu;
        private string gen;
        private int anLansare;
        private float pret;

        public Film(string titlu, string gen, int anLansare, float pret)
        {
            this.titlu = titlu;
            this.gen = gen;
            this.anLansare = anLansare;
            this.pret = pret;
        }

        public string Titlu { get => titlu; set => titlu = value; }
        public string Gen { get => gen; set => gen = value; }
        public int AnLansare { get => anLansare; set => anLansare = value; }
        public float Pret { get => pret; set => pret = value; }

        public string AfisareDetalii()
        {
           return $"Titlu: {this.Titlu}, Gen: {this.Gen}, An lansare: {this.AnLansare}, Pret: {this.Pret} lei";
        }

        public object Clone()
        {
            Film copyFilme = new Film(this.titlu, this.gen, this.anLansare, this.pret);
            return copyFilme;
        }

        public int CompareTo(object obj)
        {
            if (obj is Film)
            {
                Film f = (Film)obj;
                if (this.pret < f.pret)
                {
                    return -1;
                }
                else if (this.pret == f.pret)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return -2;
            }
        }

        public static Film operator ++(Film f)
        {
            f.pret++;
            return f;
        }

        public static implicit operator double(Film f)
        {
            return (double)f.pret;
        }

    }
}
