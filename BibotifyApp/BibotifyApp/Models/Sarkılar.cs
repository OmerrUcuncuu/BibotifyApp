using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibotifyApp.Models
{
    public class Sarkılar
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public bool HaftaninSarkısıMi { get; set; }
        public bool EnCokDinlenenMi { get; set; }

    }
}
