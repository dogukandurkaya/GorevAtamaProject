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
            throw new NotImplementedException();
        }

        public void Delete(Personel entity)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Personel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel entity)
        {
            throw new NotImplementedException();
        }
    }
}
