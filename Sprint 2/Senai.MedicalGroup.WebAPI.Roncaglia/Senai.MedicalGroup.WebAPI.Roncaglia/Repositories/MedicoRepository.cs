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

        //Cadastrar médicos
        public void cadastrarMedicos(Medicos medico)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                ctx.Medicos.Add(medico);
                ctx.SaveChanges();
            }
        }

        //Listar médicos
        public List<Medicos> listarMedicos()
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Medicos.ToList();
            }
        }

        //Apagar médico
        public void apagarMedico(int Id)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                Medicos medicoProcurado = ctx.Medicos.Find(Id);
                ctx.Medicos.Remove(medicoProcurado);
                ctx.SaveChanges();
            }
        }

    }
}
