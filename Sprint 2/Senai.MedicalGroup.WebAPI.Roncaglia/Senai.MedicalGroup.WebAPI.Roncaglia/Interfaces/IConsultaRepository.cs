using Senai.MedicalGroup.WebAPI.Roncaglia.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces
{
    interface IConsultaRepository
    {
        //Cadastra nova consulta
        void cadastrarConsulta(Consultas consulta);

        //Lista consultas de somente um médico
        List<Consultas> ConsultasMedico(int Id);

        //Lista consultas de somente um paciente
        List<Consultas> ConsultasPaciente(int Id);

        //Lista todas as consultas
        List<Consultas> TodasConsultas();
    }
}
