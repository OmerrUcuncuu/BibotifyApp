using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibotifyApp.Models
{
    public class Sarkı
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Sarki { get; set; }
        public string Sozler { get; set; }
        public bool HaftaninSarkısıMi { get; set; }
        public bool EnCokDinlenenMi { get; set; }

    }
}
