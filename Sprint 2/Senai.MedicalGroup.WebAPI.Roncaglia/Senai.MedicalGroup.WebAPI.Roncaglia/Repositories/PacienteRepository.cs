using Senai.MedicalGroup.WebAPI.Roncaglia.Domains;
using Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public List<Pacientes> ListarPacientes()
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Pacientes.ToList();
            }
        }
    }
}
