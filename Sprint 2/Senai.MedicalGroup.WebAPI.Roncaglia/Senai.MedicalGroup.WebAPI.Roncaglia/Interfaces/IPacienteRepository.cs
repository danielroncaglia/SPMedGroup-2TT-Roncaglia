using Senai.MedicalGroup.WebAPI.Roncaglia.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces
{
    internal interface IPacienteRepository
    {
        //Cadastrar nova consulta
        void cadastrarPaciente(Pacientes paciente);

        //Listar os pacientes
        List<Pacientes> listarPacientes();

        //Apagar paciente
        void apagarPaciente(int Id);

}
