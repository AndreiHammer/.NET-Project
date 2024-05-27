using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Inchiriere : IEnumerable<Film>
    {
        private int id;
        private Client client;
        private List<Film> filme = new List<Film>();
        private float totalPlata;

        public Inchiriere(Client client, List<Film> filme)
        {
            this.client = client;
            this.filme = filme;
            this.id = ++Inchiriere.idCounter;
        }

        private static int idCounter = 0;

        public Inchiriere() {
            this.id = ++Inchiriere.idCounter;
        }

        public Client Client { get => client; set => client = value; }
        public List<Film> Filme { get => filme; set => filme = value; }
        public float TotalPlata { get => totalPlata; set => totalPlata = value; }
        public int Id { get => id; set => id = value; }

        public static Inchiriere operator +(Inchiriere i, Film film)
        {
            i.filme.Add(film);
            return i;
        }

        public static Inchiriere operator -(Inchiriere i, Film film)
        {
            i.filme.Remove(film);
            return i;
        }

        public Film this[int index]
        {
            get { return this.filme[index]; }
            set { this.filme[index] = value; }
        }

        public IEnumerator<Film> GetEnumerator()
        {
            return this.filme.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ID inchiriere: " + this.Id);
            stringBuilder.AppendLine(this.client.AfisareDetalii());
            stringBuilder.AppendLine("Casete de filme inchiriate:");
            foreach(Film film in this)
            {
                stringBuilder.AppendLine(film.AfisareDetalii());
            }
            stringBuilder.AppendLine("Total de plata:" + this.totalPlata + " lei");
            return stringBuilder.ToString();
        }

        public string ClientInfo
        {
            get
            {
                return this.client.AfisareDetalii();
            }
        }

        public string FilmeInfo
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Film film in this)
                {
                    stringBuilder.AppendLine(film.AfisareDetalii());
                }
                return stringBuilder.ToString();
            }
        }

        ~Inchiriere()
        {
            Inchiriere.idCounter--;
        }

    }
}
