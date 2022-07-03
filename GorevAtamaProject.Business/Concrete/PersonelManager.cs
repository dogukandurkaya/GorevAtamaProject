using GorevAtamaProject.Business.Abstract;
using GorevAtamaProject.Data.Abstract;
using GorevAtamaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelRepository _personelRepository;

        public PersonelManager(IPersonelRepository personelRepository)
        {
            _personelRepository = personelRepository;
        }
        public void Create(Personel entity)
        {
            _personelRepository.Create(entity);
        }

        public void Delete(Personel entity)
        {
            _personelRepository.Delete(entity);
        }

        public List<Personel> GetAll()
        {
            return _personelRepository.GetAll();
        }

        public Personel GetById(int id)
        {
            return _personelRepository.GetById(id);
        }

        public void Update(Personel entity)
        {
            _personelRepository.Update(entity);
        }
    }
}
