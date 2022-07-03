using System.Collections.Generic;

namespace Beltek66.HelloMvc.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string DersAdi { get; set; }
        public int OgretmenId { get; set; }
        public virtual ICollection<Ogretmen> Ogretmenler { get; set; }
    }
}
