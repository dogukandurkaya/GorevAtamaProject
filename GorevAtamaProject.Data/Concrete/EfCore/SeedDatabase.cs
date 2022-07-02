using GorevAtamaProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Data.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new GorevAtamaProjectContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Personels.Count() == 0)
                {
                    context.Personels.AddRange(Personels);
                }
                if (context.Rols.Count() == 0)
                {
                    context.Rols.AddRange(Rols);
                }
                if (context.Islems.Count() == 0)
                {
                    context.Islems.AddRange(Islems);
                }
                context.SaveChanges();
            }
        }
        private static Rol[] Rols =
{
            new Rol() {RolAd="Rol1"},
            new Rol() {RolAd="Rol2"},
            new Rol() {RolAd="Rol3"},
            new Rol() {RolAd="Rol4"},
            new Rol() {RolAd="Rol5"},
            new Rol() {RolAd="Rol6"},
            new Rol() {RolAd="Rol7"},
            new Rol() {RolAd="Rol8"}
        };
        private static Islem[] Islems =
        {
            new Islem() {IslemAd="işlem1", IslemZorluk="1"},
            new Islem() {IslemAd="işlem2", IslemZorluk="2"},
            new Islem() {IslemAd="işlem3", IslemZorluk="3"},
            new Islem() {IslemAd="işlem4", IslemZorluk="4"},
            new Islem() {IslemAd="işlem5", IslemZorluk="5"},
            new Islem() {IslemAd="işlem6", IslemZorluk="6"},
            new Islem() {IslemAd="işlem7", IslemZorluk="7"},
            new Islem() {IslemAd="işlem8", IslemZorluk="8"}
        };
        private static Personel[] Personels =
        {
            new Personel() {PersonelAd = "Veli", PersonelSoyad="Seyrek",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Okan", PersonelSoyad="Karakoç",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Recep", PersonelSoyad="Çelimli",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Mikail", PersonelSoyad="Ayan",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Aslı", PersonelSoyad="Aytaş",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Elif", PersonelSoyad="Kaya",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Salih", PersonelSoyad="Demir",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Eren", PersonelSoyad="Örnek",Rol=Rols[0], Islem=Islems[0]}
        };

    }
}
