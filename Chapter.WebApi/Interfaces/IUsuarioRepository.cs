﻿using System.Collections.Generic;

namespace Chapter.WebApi.Models
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        void Atualizar(int id, Usuario usuario);

        void Deletar(int id);

        Usuario Login(string email, string senha);

    }
}