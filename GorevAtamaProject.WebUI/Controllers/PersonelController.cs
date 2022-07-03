using GorevAtamaProject.Business.Abstract;
using GorevAtamaProject.Data.Concrete.EfCore;
using GorevAtamaProject.Entity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GorevAtamaProject.WebUI.Controllers
{
    public class PersonelController : Controller
    {
        private IPersonelService _personelService;

        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonelList()
        {
            var values = _personelService.GetListAll();
            return View(values);
        }

        public IActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonelEkle(Personel personel)
        {
            int rnd1 = new Random().Next(1, 8);
            personel.RolID = rnd1;
            int rnd2 = new Random().Next(1, 8);
            personel.IslemID = rnd2;
            _personelService.Create(personel);
            return RedirectToAction("PersonelList", "Personel");
        }

        public IActionResult PersonelDuzenle(int id)
        {
            var values = _personelService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult PersonelDuzenle(Personel personel)
        {
            var entity = _personelService.GetById(personel.PersonelID);
            entity.PersonelAd = personel.PersonelAd;
            entity.PersonelSoyad = personel.PersonelSoyad;
            _personelService.Update(entity);
            return RedirectToAction("PersonelList", "Personel");
        }

        public IActionResult PersonelSil(int id)
        {
            var entity = _personelService.GetById(id);
            _personelService.Delete(entity);
            return RedirectToAction("PersonelList", "Personel");
        }

        public IActionResult PersonelAta(Personel personel)
        {
            int rnd = new Random().Next(1, 8);
            personel.IslemID = rnd;
            ViewBag.v1 = rnd;

            var values = _personelService.GetListAll();
            return View(values);
        }
    }
}
