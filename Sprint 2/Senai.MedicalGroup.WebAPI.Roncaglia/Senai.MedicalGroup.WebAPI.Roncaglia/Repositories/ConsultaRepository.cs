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
        //Cadastrar nova consulta
        public void cadastrarConsulta(Consultas consulta)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                ctx.Consultas.Add(consulta);
                ctx.SaveChanges();
            }
        }

        //Listar consultas de somente um médico
        public List<Consultas> consultaporMedico(int Id)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Consultas.Where(x => x.IdMedico == Id).ToList();
            }
        }

        //Listar consultas de somente um paciente
        public List<Consultas> consultaporPaciente(int Id)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Consultas.Where(x => x.IdPaciente == Id).ToList();
            }
        }

        //Listar todas as consultas
        public List<Consultas> todasConsultas()
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Consultas.ToList();
            }
        }

        //Apagar consulta
        public void apagarConsulta(int Id)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                Consultas consultaProcurada = ctx.Consultas.Find(Id);
                ctx.Consultas.Remove(consultaProcurada);
                ctx.SaveChanges();
            }
        }

        //Buscar consulta por id
        public Consultas consultasporID(int Id)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Consultas.Find(Id);
            }
        }

        public void atualizarConsulta(Consultas consulta)
        {

            using (MedGroupContext ctx = new MedGroupContext())
            { 
                ctx.Consultas.Update(consulta);
                ctx.SaveChanges();
            }
        }

    }
}
