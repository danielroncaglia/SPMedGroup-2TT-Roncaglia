using Senai.MedicalGroup.WebAPI.Roncaglia.Domains;
using Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {

        public List<Medicos> ListarMedicos()
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Medicos.ToList();
            }
        }
    }
}
