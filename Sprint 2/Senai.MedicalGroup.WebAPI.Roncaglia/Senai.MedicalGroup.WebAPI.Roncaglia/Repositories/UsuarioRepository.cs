using Senai.MedicalGroup.WebAPI.Roncaglia.Domains;
using Senai.MedicalGroup.WebAPI.Roncaglia.Interfaces;
using Senai.MedicalGroup.WebAPI.Roncaglia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MedicalGroup.WebAPI.Roncaglia.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuarios BuscarPorEmailESenha(LoginViewModel login)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                return ctx.Usuarios.Include(x => x.Id).FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);
            }
        }

        public void Cadastrar(Usuarios usuario)
        {
            using (MedGroupContext ctx = new MedGroupContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }
    }
}