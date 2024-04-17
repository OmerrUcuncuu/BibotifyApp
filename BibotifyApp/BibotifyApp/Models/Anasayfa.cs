using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibotifyApp.Models
{
    public class AnasayfaViewModel
    {
        public List<Sarkı> HaftaninUrunleri { get; set; }
        public List<Sarkı> EnCokSatanlar { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}
