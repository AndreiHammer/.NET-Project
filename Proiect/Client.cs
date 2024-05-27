using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Client : ICloneable, IComparable, IDetails
    {
        private string numeClient;
        private string adresa;
        private string numarTelefon;

        public Client(string numeClient, string adresa, string numarTelefon)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.numarTelefon = numarTelefon;
        }

        public string NumeClient { get => numeClient; set => numeClient = value; }
        public string NumarTelefon { get => numarTelefon; set => numarTelefon = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        public string AfisareDetalii()
        {
            return $"Nume client: {this.NumeClient}, Adresa: {this.adresa}, Telefon: {this.NumarTelefon}";
        }

        public object Clone()
        {
            Client copy = new Client(this.numeClient, this.adresa, this.numarTelefon);
            return copy;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Client otherClient)
            {
                return this.numarTelefon.CompareTo(otherClient.numarTelefon);
            }
            throw new ArgumentException("Objectul nu este de tip Client.");
        }

        public static bool operator >(Client client1, Client client2)
        {
            return string.Compare(client1.numeClient, client2.numeClient) > 0;
        }

        public static bool operator <(Client client1, Client client2)
        {
            return string.Compare(client1.numeClient, client2.numeClient) < 0;
        }

    }
}
