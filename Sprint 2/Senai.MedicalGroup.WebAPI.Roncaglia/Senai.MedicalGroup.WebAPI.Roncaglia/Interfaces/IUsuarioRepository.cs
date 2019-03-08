using Senai.MedicalGroup.WebAPI.Roncaglia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Domains.ViewModels usuario);

        LoginViewModel BuscarPorEmailSenha(LoginViewModel Login);
    }
}
