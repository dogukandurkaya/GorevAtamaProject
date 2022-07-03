using GorevAtamaProject.Business.Abstract;
using GorevAtamaProject.Data.Concrete.EfCore;
using GorevAtamaProject.Entity;
using Microsoft.AspNetCore.Mvc;

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
            var values = _personelService.GetAll();
            return View(values);
        }

        public IActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonelEkle(Personel personel)
        {
            personel.RolID = 1;
            personel.IslemID = 1;
            _personelService.Create(personel);
            return RedirectToAction("PersonelList", "Personel");
        }

        public IActionResult PersonelDuzenle(int id)
        {
            var values = _personelService.GetById(id);
            return View(values);
        }

        public IActionResult PersonelSil(int id)
        {
            var entity = _personelService.GetById(id);
            _personelService.Delete(entity);
            return RedirectToAction("PersonelList", "Personel");
        }
    }
}
