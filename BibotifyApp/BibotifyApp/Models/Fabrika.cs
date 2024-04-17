using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibotifyApp.Models
{
    public class Fabrika
    {
        public static List<Sarkı> Sarkılar { get; set; } = new List<Sarkı>
        {
            new Sarkı{
                Id=1,
                KategoriId=2,
                Ad="Killoki  Ege Boran & Kuty - Yardım Et Tanrım",
                Resim= "yardımet tanrım.gif",
                Sarki="yardimettanrim.mp3",
                Sozler=$"Kırk kilo kızıl bi' kızla tanıştım (Slatt) \n"+
                $"Sanırım fazla alıştım (Paow) \n"+
                $"Kafam bi' hayli karıştı \n"+
                $"Saymadım ama elli kez barıştık (Nasıl?) \n"+
                $"Görünce seni hep gözüm kamaştı (Nasıl?) \n"+
                $"Senden kaçamadım \n"+
                $"Sonbahar gibi saçların sarardı \n"+
                $"Severdin bu yüzden sıkı sarardım (Paow) \n"+
                $"Getirdi sonumu ciğerlerim kara \n"+
                $"Dönüp de bakmam arkama \n"+
                $"Borçluyum sadece haplara (Slatt) \n"+
                $"Gözlerim hâlâ kapkara (Slatt) \n"+
                $"Hâlâ kapkara \n"+
                $"Duymasa da dua et tanrına (Pray God) \n"+
                $"Anılar dönüşün sanrıya, anılar dönüşür sancıya (Ah) \n"+
                $"Derdimi olmadı anlayan (Gang) \n"+
                $"Yılları ettim hep ziyan (Paow) \n"+
                $"Deneyip durdum hep bi' daha (Durdum hep bi' daha) \n"+
                $"Deneyip durdum hep bi' daha (Hep bi' daha, hep bi' daha) \n"+
                $"Çekersin tonla acı (Ah), hangi kadın? \n"+
                $"Doldurur yerini hangi kadın? Söyle \n"+
                $"Bu benim handikapım, ya ah, bu yüzden dolu kabım \n \n"+
                $"[Nakarat: Ege Boran & 13 Killoki] \n"+
                $"Sırtım dolu bıçak yaraları (Ah, ah) \n"+
                $"(Sırtım dolu bıçak yaraları) \n"+
                $"(Kalbim boşken, yardım et tanrım) \n"+
                $"Bana yardım et tanrım (Yeah) \n"+
                $"Yardım et tanrım \n"+
                $"Bana yardım et tanrım \n"+
                $"(Bana yardım еt tanrım) Ey, ah \n"+
                $"Bana yardım et tanrım, ah \n \n"+
                $"[Verse 2: Kuty] \n"+
                $"Ey, kalbime kelеpçe taktım \n"+
                $"Bunları görmezden gelemem hiç \n"+
                $"Bileğime yaralar açtım \n"+
                $"İlaçlar midemde kusamam hiç \n"+
                $"Birini aramadım en sık çağrım 112 \n"+
                $"Kimseye soramadım, düştüğümde kalkamadım ve bu beni yaraladı ah \n"+
                $"Yakın dostum xanny hatırlatıyo' bana her gece seni \n"+
                $"Unutamıyorum içmezsem görmezden gelemiyorum hiç seni \n"+
                $"Bağdatteyken ya da cadde üstünden geçmiş yıllar hep \n"+
                $"Yirmi bir kulübü gençliğimi yaşım olucak yirmi yedi (Ha) \n \n"+
                $"[Nakarat: Ege Boran & 13 Killoki] \n"+
                $"Sırtım dolu bıçak yaraları (Ah, ah) \n"+
                $"(Sırtım dolu bıçak yaraları) \n"+
                $"(Kalbim boşken, yardım et tanrım) \n"+
                $"Bana yardım et tanrım (Yeah) \n"+
                $"Yardım et tanrım \n"+
                $"(Bana yardım et tanrım) Ey, ah \n"+
                $"Bana yardım et tanrım, ah \n"+
                $"[Nakarat: Ege Boran & 13 Killoki] \n"+
                $"Sırtım dolu bıçak yaraları (Ah, ah) \n"+
                $"(Sırtım dolu bıçak yaraları) \n"+
                $"(Kalbim boşken, yardım et tanrım) \n"+
                $"Bana yardım et tanrım (Yeah) \n"+
                $"Yardım et tanrım \n"+
                $"Bana yardım et tanrım \n"+
                $"(Bana yardım еt tanrım) Ey, ah \n"+
                $"Bana yardım et tanrım, ah \n \n",
                HaftaninSarkısıMi=false,
                EnCokDinlenenMi=true,
                Aciklama="Sosyal medayada ünlü olan 13Killoki'nin şarkısı! Dinlemek için butona tıkla"
            },
            new Sarkı
            {
                Id=2,
                KategoriId=2,
                Ad="Abugat - Cartier Gözlükler",
                Resim="cartiergozlukler.jpg",
                Sarki="cartiergozlukler.mp3",
                Sozler=$"Ah, ah, ah, ah, ah \n" +
                $"Öldür duyguları \n" +
                $"Söyle geriye ne bıraktın? \n" +
                $"Dördü yirmi geçer \n"+
                $"Ama hala aramadın \n"+
                $"Söndü mü tüm şansım? \n"+
                $"Böyle neden geri kaldım? \n"+
                $"Cartier gözlükler \n"+
                $"Gözyaşlarımız saklı \n"+
                $"Öldür duyguları \n" +
                $"Söyle geriye ne bıraktın? \n" +
                $"Dördü yirmi geçer \n"+
                $"Ama hala aramadın \n"+
                $"Söndü mü tüm şansım? \n"+
                $"Böyle neden geri kaldım? \n"+
                $"Cartier gözlükler \n"+
                $"Gözyaşlarımız saklı \n"+
                $"Buluşmada giydim terlik \n"+
                $"Kız dedi \"Değilsin benlik\" \n"+
                $" \"Hayır, aptal olma bebek \n"+
                $" Çıkarıyon hep bi terslik\" \n"+
                $" \"Söyle, adın ne güzellik? \n"+
                $"Bu gece olayım sensin\"\n"+
                $"Güven tek seferlik\n"+
                $"Bеbek, etme hiç tеmbellik\n"+
                $"Dolu pembe rujla boynum\n"+
                $"Evet seviyo\' benle oyunu\n"+
                $"Soldum terlemekten\n"+
                $"Ama bacak taşır omzum\n"+
                $"Bebek suratıma otur\n"+
                $"Bense Hasan gibi boğuldum\n"+
                $"Oldu deniz kadar ıslak\n"+
                $"Ve de gerekiyo' kolluk\n"+
                $"Öldür duyguları \n" +
                $"Söyle geriye ne bıraktın? \n" +
                $"Dördü yirmi geçer \n"+
                $"Ama hala aramadın \n"+
                $"Söndü mü tüm şansım? \n"+
                $"Böyle neden geri kaldım? \n"+
                $"Cartier gözlükler \n"+
                $"Gözyaşlarımız saklı \n"+
                $"Öldür duyguları \n" +
                $"Söyle geriye ne bıraktın? \n" +
                $"Dördü yirmi geçer \n"+
                $"Ama hala aramadın \n"+
                $"Söndü mü tüm şansım? \n"+
                $"Böyle neden geri kaldım? \n"+
                $"Cartier gözlükler \n"+
                $"Gözyaşlarımız saklı \n",
                HaftaninSarkısıMi=false,
                EnCokDinlenenMi=true,
                Aciklama="Fena sarki"
            },
            new Sarkı
            {
                Id=3,
                KategoriId=4,
                Ad="Cengiz Kurtoğlu - Küllenen Aşk",
                Resim="cengizkurtoglu.jpg",
                Sarki="kullenenask.mp3",
                Sozler=$"Yıllardır küllenmiş aşkın var bende \n" +
                $"Aşkın mekan kurmuş yanan gönlümde \n" +
                $" Beni terkedipte gittiğin halde \n" +
                $"Sana intizara kıyamıyorum \n"+
                $"Aşkın mekan kurmuş yanan gönlümde \n"+
                $"Beni terkedipte gittiğin halde \n"+
                $"Sana intizara kıyamıyorum \n"+
                $"Benim kadar sevene rastlamadıysan \n"+
                $"Dertlere çare bulamadıysan \n"+
                $"Benim kadar sevene rastlamadıysan \n" +
                $"Dertlere çare bulamadıysan \n" +
                $"Gittiğin yerlerde garip kaldıysan \n"+
                $"Geri dön... \n"+
                $"O eski yerimizde beklerim seni \n"+
                $"Üzülme sevgilim affettim seni \n"+
                $"Geri dön... \n"+
                $"O eski yerimizde beklerim seni \n"+
                $"Üzülme sevgilim affettim seni \n"+
                $"Bir Mecnun yarattın çöldeyim şimdi \n"+
                $" Eskiden volkandım kül oldum şimdi \n"+
                $"En büyük aşkımdın el oldun şimdi \n"+
                $"Sana intizara kıyamıyorum \n"+
                $"Bir Mecnun yarattın çöldeyim şimdi\n"+
                $"Eskiden volkandım kül oldum şimdi\n"+
                $"En büyük aşkımdın el oldun şimdi\n"+
                $"Sana intizara kıyamıyorum\n"+
                $"Benim kadar sevene rastlamadıysan\n"+
                $"Dertlere çare bulamadıysan\n"+
                $"Benim kadar sevene rastlamadıysan\n"+
                $"Dertlere çare bulamadıysan\n"+
                $"Gittiğin yerlerde garip kaldıysan\n"+
                $"Geri dön...\n"+
                $"O eski yerimizde beklerim seni\n"+
                $"Üzülme sevgilim affettim seni \n" +
                $"Geri dön... \n" +
                $"O eski yerimizde beklerim seni \n"+
                $"Üzülme sevgilim affettim seni\n",
                HaftaninSarkısıMi=false,
                EnCokDinlenenMi=true,
                Aciklama="hondacivic"
            },
        };
        public static List<Kategori> Kategoriler { get; set; } = new List<Kategori>
        {
            new Kategori{ Id = 1, Ad="Pop"},
            new Kategori{ Id = 2, Ad="Rap"},
            new Kategori{ Id = 3, Ad="Rock"},
            new Kategori{ Id = 4, Ad="Arebesk"},
            new Kategori{ Id = 5, Ad="Jazz"},
            new Kategori{ Id = 5, Ad="Caz Müziği"},

        };
    }
}
