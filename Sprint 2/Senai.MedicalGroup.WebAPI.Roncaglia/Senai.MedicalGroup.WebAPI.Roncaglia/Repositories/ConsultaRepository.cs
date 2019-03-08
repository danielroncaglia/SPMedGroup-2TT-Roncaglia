using Senai.MedicalGroup.WebAPI.Roncaglia.Domains;
using Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        //Cadastra nova consulta
        public void cadastrarConsulta (Consultas consulta)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                ctx.Consultas.Add(consulta);
                ctx.SaveChanges();
            }
        }

        //Lista consultas de somente um médico
        public List<Consultas> ConsultasMedico(int Id)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Consultas.Where(x => x.IdMedico == Id).ToList();
            }
        }

        //Lista consultas de somente um paciente
        public List<Consultas> ConsultasPaciente(int Id)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Consultas.Where(x => x.IdPaciente == Id).ToList();
            }
        }

        //Lista todas as consultas
        public List<Consultas> TodasConsultas()
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Consultas.ToList();
            }
        }
    }
}
