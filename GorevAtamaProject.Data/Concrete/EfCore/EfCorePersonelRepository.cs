using GorevAtamaProject.Data.Abstract;
using GorevAtamaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Data.Concrete.EfCore
{
    public class EfCorePersonelRepository : EfCoreGenericRepository<Personel>, IPersonelRepository
    {

    }
}
