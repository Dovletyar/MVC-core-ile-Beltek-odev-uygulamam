using System.Collections.Generic;

namespace Beltek66.HelloMvc.Models
{
    public class Ogretmen
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        public virtual ICollection<Ders> Dersler { get; set; }

    }
}
